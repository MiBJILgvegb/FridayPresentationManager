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
using PowerPoint = Microsoft.Office.Interop.PowerPoint;


namespace FridayPresentationManager
{
    public partial class MainWindow : Form
    {
        public static MainWindow mainWindow;
        private PictureBox currentPresentationPB = null;
        internal string currentPresentationsPath = "";
        public Department[] departments=null;

        public string mainPresentationsDirectory = Directory.GetCurrentDirectory();
        public string mainImagesDirectory = Path.Combine(Directory.GetCurrentDirectory(),"images");

        //==================================================================================================
        private void InitializeINIParameters()
        {//считываем параметры
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

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
        internal void PreparePresentataions(ListBox sender)
        {
            currentPresentationsPath = GetPresentationsFolderFromListBox();
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            string[] departmensNames;
            INI.GetPrivateProfileSection(Consts.configSectionsName_departmentslist,out departmensNames);

            for(int i = 0; i < departmensNames.Count(); i++) { departmensNames[i] = departmensNames[i].Split('=')[1]; }

            departments = null;
            departments = new Department[departmensNames.Count()];
            for(int i=0;i<departmensNames.Count();i++)
            {
                departments[i] = new Department(departmensNames[i],this.gbDepartmentList);
            }
        }
        //==================================================================================================
        public MainWindow()
        {
            mainWindow = this;
            InitializeComponent();
            InitializeINIParameters();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FillYearsList()
        {
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
            if (tbPresentationsFolderPath.Text.Length > 0) { Process.Start(tbPresentationsFolderPath.Text); }
        }

        private void lbPresentationsDatesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListBox).Items.Count > 0)
            {
                if (departments != null)
                {
                    for (int i = 0; i < departments.Count(); i++) { departments[i].Destroy(); }
                }
                PreparePresentataions(sender as ListBox);
            }
        }

        private void cbPresentationByYearsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareDatesList(cbPresentationByYearsFilter.SelectedItem.ToString());
            if (lbPresentationsDatesList.Items.Count > 0)
                lbPresentationsDatesList.SetSelected(0, true);
        }

        private void presentationsNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationsNames presentationsNames = new PresentationsNames();
            presentationsNames.Show();
        }
    }
}
