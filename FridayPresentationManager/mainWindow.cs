using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FridayPresentationManager.Properties;
using iniFiles;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace FridayPresentationManager
{
    public partial class MainWindow : Form
    {
        public static MainWindow mainWindow;
        private PictureBox currentPresentationPB=null;
        public string mainPresentationsDirectory = Directory.GetCurrentDirectory();
        public string mainImagesDirectory = Path.Combine(Directory.GetCurrentDirectory(),"images");

        public Dictionary<string, string> varDepartmentsNamesToDeputyNames = new Dictionary<string, string>();
        public Dictionary<int, string> varIntToNames = new Dictionary<int, string>();
        public Dictionary<string, string> varNamesToPresentations = new Dictionary<string, string>();
        public Dictionary<string, string> varDeputyPresentationsNames = new Dictionary<string, string>();
        public Dictionary<string, string> varDeputyPresentationsExts= new Dictionary<string, string>();
        public Dictionary<string, string> varFirstDeputyDeputyNames = new Dictionary<string, string>();
        public Dictionary<string, string> varDeputyDeputyNames = new Dictionary<string, string>();
        public Dictionary<string, string> varPresentations = new Dictionary<string, string>();

        //==================================================================================================
        private string DictionaryGetKeyByIndex(Dictionary<string,string> dict,int ind)
        {
            int i = 0;
            foreach (KeyValuePair<string, string> kvp in dict)
            {
                if (i == ind) { return kvp.Key; }
                i++;
            }
            return "";
        }
        internal string DictionaryGetKeyByValue(Dictionary<string, string> dict, string val)
        {
            int i = 0;
            foreach (var pair in dict)
            {
                if (pair.Value == val) { return pair.Key; }
                i++;
            }

            return null;
        }
        //==================================================================================================
        private void InitializeDeputyPhotos()
        {//инициализируем фотографии
            foreach (var departmentName in varDepartmentsNamesToDeputyNames)
            {
                string imagePath = Path.Combine(mainImagesDirectory, departmentName.Value+ Consts.imagesEXT);
                Image image = (Image)Properties.Resources.ResourceManager.GetObject(Consts.imagesDefaultPhoto);

                if (File.Exists(imagePath))
                {
                    Gui.SetPicture((this.Controls["gbDeputyList"].Controls["pb" + departmentName.Key] as PictureBox), Image.FromFile(imagePath));
                }
                else
                {
                    Gui.SetPicture((this.Controls["gbDeputyList"].Controls["pb" + departmentName.Key] as PictureBox), image);
                }

                Gui.SetPicture((this.Controls["gbDeputyList"].Controls["pb" + departmentName.Key + "Marker"] as PictureBox), (Image)Properties.Resources.ResourceManager.GetObject(Consts.imagesErrorPhoto));
            }
        }
        private void InitializeINIParameters()
        {//считываем параметры
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            
            foreach(string departmentName in Consts.departmentsNames)
            {
                //получаем имена заместителей
                varDepartmentsNamesToDeputyNames[departmentName] = "";
                if (INI.KeyExists(Consts.configSectionsName_deputyfio, departmentName))
                {
                    varDepartmentsNamesToDeputyNames[departmentName] = INI.ReadINI(Consts.configSectionsName_deputyfio, departmentName);
                }

                //получаем имена первых заместителей заместителей
                varFirstDeputyDeputyNames[departmentName] = "";
                if (INI.KeyExists(Consts.configSectionsName_firstdeputyfio, departmentName))
                {
                    varFirstDeputyDeputyNames[departmentName] = INI.ReadINI(Consts.configSectionsName_firstdeputyfio, departmentName);
                }

                //получаем имена заместителей заместителей
                varDeputyDeputyNames[departmentName] = "";
                if(INI.KeyExists(Consts.configSectionsName_deputydeputyfio, departmentName))
                {
                    varDeputyDeputyNames[departmentName] = INI.ReadINI(Consts.configSectionsName_deputydeputyfio, departmentName);
                }

                //получаем список предустановленных имен для презентаций
                varDeputyPresentationsNames[departmentName] = "";
                if (varDepartmentsNamesToDeputyNames[departmentName].Length > 0) { varDeputyPresentationsNames[departmentName] = varDepartmentsNamesToDeputyNames[departmentName]; }
                else if (varFirstDeputyDeputyNames[departmentName].Length > 0) { varDeputyPresentationsNames[departmentName] = varDepartmentsNamesToDeputyNames[departmentName]; }
                else if (varDeputyDeputyNames[departmentName].Length > 0) { varDeputyPresentationsNames[departmentName] = varDeputyDeputyNames[departmentName]; }
                if(INI.KeyExists(Consts.configSectionsName_presentationsNames, departmentName))
                {
                    varDeputyPresentationsNames[departmentName] = INI.ReadINI(Consts.configSectionsName_presentationsNames, departmentName);
                }

                //получаем предустановленные расширения для презентаций
                varDeputyPresentationsExts[departmentName] = Consts.presentationEXT[0];
                if (INI.KeyExists(Consts.configSectionsName_presentationsExts, departmentName))
                {
                    varDeputyPresentationsExts[departmentName] = INI.ReadINI(Consts.configSectionsName_presentationsExts, departmentName);
                }
            }

            //получаем путь к корневой папке с презентациями
            if (INI.KeyExists(Consts.configSectionsName_path, Consts.configKeysName_presentationFolder))
            {
                mainPresentationsDirectory = INI.ReadINI(Consts.configSectionsName_path, Consts.configKeysName_presentationFolder);
                tbPresentationsFolderPath.Text = mainPresentationsDirectory;
            }

            //получаем путь к папке с фотографиями
            if (INI.KeyExists(Consts.configSectionsName_path, Consts.configKeysName_imagesFolder))
            {
                mainImagesDirectory = INI.ReadINI(Consts.configSectionsName_path, Consts.configKeysName_imagesFolder);
            }
        }
        internal ToolStripMenuItem CreateToolStripItem(string name,string text/*, EventHandler eventHandler*/)
        {
            ToolStripMenuItem toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            //toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCut.Image")));
            toolStripMenuItem.Name = "tsmi"+ name;
            toolStripMenuItem.Size = new System.Drawing.Size(175, 25);
            toolStripMenuItem.Text = text;
            //toolStripMenuItem.Click += eventHandler;

            return toolStripMenuItem;
        }
        internal void PrepareContextMenuStrip()
        {
            foreach (string departmentName in Consts.departmentsNames)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.Name = "cmsPB"+ departmentName;
                contextMenuStrip.Size = new System.Drawing.Size(60, 4);

                if (varFirstDeputyDeputyNames[departmentName].Length > 0)
                {
                    ToolStripMenuItem tsmiFirstDeputyMenuItem = CreateToolStripItem("tsmi" + departmentName + "FirstDeputyMenuItem", varFirstDeputyDeputyNames[departmentName]);
                    contextMenuStrip.Items.AddRange(new[] { tsmiFirstDeputyMenuItem});
                }
                if (varDeputyDeputyNames[departmentName].Length > 0)
                {
                    ToolStripMenuItem tsmiDeputyDeputyMenuItem = CreateToolStripItem("tsmi" + departmentName + "DeputyDeputyMenuItem", varDeputyDeputyNames[departmentName]);
                    contextMenuStrip.Items.AddRange(new[] { tsmiDeputyDeputyMenuItem });
                }

                //contextMenuStrip.Items.AddRange(new[] { tsmiFirstDeputyMenuItem, tsmiDeputyDeputyMenuItem });
                (this.Controls["gbDeputyList"].Controls["pb" + departmentName] as PictureBox).ContextMenuStrip = contextMenuStrip;
            }
        }
        internal void SelectPresentation(object sender, EventArgs e)
        {

        }
        
        internal void SaveINIConfig(string section,string key,string value)
        {//сохраняем настройки в файле конфигурации
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            INI.Write(section, key, value);
        }
        private string GetPresentationsFolderFromListBox()
        {//получаем полный путь к папке с текущими презентациями
            string[] lbItem=lbPresentationsDatesList.SelectedItem.ToString().Split('.');

            return Path.Combine(mainPresentationsDirectory,cbPresentationByYearsFilter.Text, lbItem[1], lbItem[0]);
        }
        private void SetMarkersDefault()
        {//устанавливаем дефолтные маркеры наличия презентаций
            foreach(var deputy in varDepartmentsNamesToDeputyNames)
            {
                Gui.SetPicture(this.Controls["gbDeputyList"].Controls["pb" + deputy.Key + "Marker"] as PictureBox, (Image)Properties.Resources.ResourceManager.GetObject(Consts.imagesErrorPhoto));
                //(this.Controls["gbDeputyList"].Controls["pb" + deputy.Key] as PictureBox).Click += null;
            }
        }
        private void SetCurrentPresentationMarker(string deputyPBName)
        {//устанавливаем маркер текущей запущеной презентации
            if (currentPresentationPB != null)
            {
                currentPresentationPB.Image= (Image)Properties.Resources.ResourceManager.GetObject(Consts.imagesOKPhoto);
            }
            
            (this.Controls["gbDeputyList"].Controls[deputyPBName + "Marker"] as PictureBox).Image = (Image)Properties.Resources.ResourceManager.GetObject(Consts.imagesCurrentPhoto);
            currentPresentationPB = (this.Controls["gbDeputyList"].Controls[deputyPBName + "Marker"] as PictureBox);
        }
        //==================================================================================================
        internal bool PreparePresentationList(string path)
        {//получаем список презентаций в папке
            if (!Directory.Exists(path)) return false;
            
            foreach(var deputyPresentationName in varDeputyPresentationsNames)
            {
                varPresentations[deputyPresentationName.Key] = "";
                if (Directory.GetFiles(path, deputyPresentationName.Value + varDeputyPresentationsExts[deputyPresentationName.Key]+'?').Count() > 0)
                {
                    varPresentations[deputyPresentationName.Key] = deputyPresentationName.Value + varDeputyPresentationsExts[deputyPresentationName.Key];
                }
            }
            return true;
        }
        private string[] PrepareYearsList(string folder)
        {//подготавливаем список папок (учитываются только папки которые начинаются с цифр)
            string[] years = Directory.GetDirectories(folder);

            for(int i = 0; i < years.Count(); i++)
            {
                string year = new DirectoryInfo(years[i]).Name;
                if (char.IsDigit(year[0])) { years[i] = year; }
                else { years[i] = ""; }
            }
            return years;
            
        }
        private void PrepareDatesList(string year)
        {//создаем список папок с презентациями за выбранный год
            string[] months= Directory.GetDirectories(Path.Combine(mainPresentationsDirectory,year));
            if (months.Count() > 0) FormToGui.MainWindowFolderList_Clear();
            for(int i= months.Count()-1; i>=0;i--)
            {
                string month = new DirectoryInfo(months[i]).Name;
                string[] dates= Directory.GetDirectories(Path.Combine(mainPresentationsDirectory, year,month));
                for (int j=dates.Count()-1;j>=0;j--)
                {
                    FormToGui.MainWindowFolderList_Add(new DirectoryInfo(dates[j]).Name + '.' + month);
                }
                
            }
        }
        private void CheckPresentation(string deputyName)
        {
            //varNamesToPresentations[deputyName] = presentation;
        }
        private void PreparePBEvents()
        {//привязываем обработчик клика мышкой к PictureBox
            foreach (var presentation in varPresentations)
            {
                if (presentation.Value.Length > 0)
                {
                    (this.Controls["gbDeputyList"].Controls["pb" + presentation.Key] as PictureBox).Click += new System.EventHandler(this.pbDeputy_MouseClick);
                }
            }
        }
        private void PreparePBMarkers_OK(Dictionary<string,string> presentationsList)
        {//устанавливаем маркеры на презентациях, которые найдены в выбраной папке
            foreach (var presentation in presentationsList)
            {
                if (presentation.Value.Length > 0)
                {
                    Gui.SetPicture((this.Controls["gbDeputyList"].Controls["pb" + presentation.Key + "Marker"] as PictureBox), (Image)Properties.Resources.ResourceManager.GetObject(Consts.imagesOKPhoto));
                }
            }
        }
        private void PreparePresentataions()
        {
            SetMarkersDefault();

            if (!PreparePresentationList(GetPresentationsFolderFromListBox())) 
            {
                FormToGui.MainWindowFolderList_Clear();
                return;
            }
            PreparePBMarkers_OK(varPresentations);
            
        }
        private void OpenPresentation(string presentationPath)
        {
            PowerPoint.Application objApp = new PowerPoint.Application();
            PowerPoint.Presentations objPresSet = objApp.Presentations;
            PowerPoint.Presentation objPres = objPresSet.Open(presentationPath);

            objPres.SlideShowSettings.Run();
        }
        private string GetDeputyNameFromPictureBox(PictureBox pictureBox)
        {
            return pictureBox.Name.Substring(2);
        }
        //==================================================================================================
        private void DeputyPictureClick(PictureBox sender)
        {
            SetCurrentPresentationMarker(sender.Name);
            //OpenPresentation(varNamesToPresentations[GetDeputyNameFromPictureBox(sender)]);
        }
        //==================================================================================================
        public MainWindow()
        {
            mainWindow = this;
            InitializeComponent();
            InitializeINIParameters();
            InitializeDeputyPhotos();

            PrepareContextMenuStrip();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FillYearsList()
        {
            //string[] years=PrepareYearsList(mainPresentationsDirectory);
            FormToGui.MainWindowFolderFilter_Add(PrepareYearsList(mainPresentationsDirectory), false);
            FormToGui.MainWindowFolderFilter_SelectItem(0);
        }
        private void FillDatesList()
        {
            PrepareDatesList(cbPresentationByYearsFilter.SelectedItem.ToString());
            FormToGui.MainWindowFolderList_SelectItem(0);
            
        }
        private void MainWindowLoad()
        {
            if (mainPresentationsDirectory.Length > 0)
            {
                FillYearsList();
                FillDatesList();
            }

            PreparePBEvents();
        }
        private void mainWindow_Load(object sender, EventArgs e)
        {
            MainWindowLoad();
        }

        private void deputyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeputyFIO deputyFIO = new DeputyFIO();
            deputyFIO.Show();
        }

        private void pbDeputy_MouseClick(object sender, EventArgs e)
        {
            
            if((e as MouseEventArgs).Button == MouseButtons.Left)
            {
                DeputyPictureClick(sender as PictureBox);
            }
            /*else if((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                
                cmsPB.Items[0].Text=varDeputyDeputyNames[GetDeputyNameFromPictureBox(sender as PictureBox)];
                (sender as PictureBox).ContextMenuStrip = cmsPB;
            }*/
        }

        private void bBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderPresentationsDialog.ShowDialog() == DialogResult.OK)
            {
                tbPresentationsFolderPath.Text = folderPresentationsDialog.SelectedPath;
                SaveINIConfig(Consts.configSectionsName_path, Consts.configKeysName_presentationFolder, folderPresentationsDialog.SelectedPath);

                mainPresentationsDirectory = tbPresentationsFolderPath.Text;

                MainWindowLoad();
            }
        }

        private void bExploreFolder_Click(object sender, EventArgs e)
        {
            if (tbPresentationsFolderPath.Text.Length > 0) Process.Start(tbPresentationsFolderPath.Text);
        }

        private void lbPresentationsDatesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreparePresentataions();
        }

        private void cbPresentationByYearsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareDatesList(cbPresentationByYearsFilter.SelectedItem.ToString());
            if (lbPresentationsDatesList.Items.Count > 0)
                lbPresentationsDatesList.SetSelected(0, true);
        }

        private void presentationsNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
