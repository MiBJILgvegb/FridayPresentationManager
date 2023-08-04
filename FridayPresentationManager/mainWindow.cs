using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using FridayPresentationManager.Properties;
using iniFiles;
//using PowerPoint = Microsoft.Office.Interop.PowerPoint;


namespace FridayPresentationManager
{
    public partial class MainWindow : Form
    {
        public static MainWindow mainWindow;
        internal string currentPresentationsPath = "";
        public Department[] departments=null;
        internal Settings settings;
        internal Updater updater;
        internal ProgressStatus progress=null;

        //public string mainPresentationsDirectory = Directory.GetCurrentDirectory();
        //public string mainImagesDirectory = Path.Combine(Directory.GetCurrentDirectory(),"images");

        //==================================================================================================
        private string GetPresentationsFolderFromListBox()
        {//получаем полный путь к папке с текущими презентациями
            string[] lbItem=lbPresentationsDatesList.SelectedItem.ToString().Split('.');

            return Path.Combine(settings.mainPresentationsDirectory,cbPresentationByYearsFilter.Text, lbItem[1], lbItem[0]);
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
            string[] months= Directory.GetDirectories(Path.Combine(settings.mainPresentationsDirectory,year));
            if (months.Count() > 0) Gui.Clear(MainWindow.mainWindow.lbPresentationsDatesList);
            for (int i= months.Count()-1; i>=0;i--)
            {
                string month = new DirectoryInfo(months[i]).Name;
                string[] dates= Directory.GetDirectories(Path.Combine(settings.mainPresentationsDirectory, year,month));
                for (int j=dates.Count()-1;j>=0;j--)
                {
                    Gui.Add(MainWindow.mainWindow.lbPresentationsDatesList, new DirectoryInfo(dates[j]).Name + '.' + month);
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

            if (departments != null) { for (int i = 0; i < departments.Count(); i++) { departments[i].Destroy(); } }
            //departments = null;
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
            settings = new Settings();
            
            //updater = new Updater(settings.serverDirectory);
            //InitializeINIParameters();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FillYearsList()
        {
            FormToGui.MainWindowFolderFilter_Add(PrepareYearsList(settings.mainPresentationsDirectory), false);

            Gui.SelectIndex(MainWindow.mainWindow.cbPresentationByYearsFilter, 0);
        }
        private void FillYearsListAsync()
        {
            //BeginInvoke(new Action(() => { FillYearsList(); } ));
            FormToGui.MainWindowFolderFilter_AddAsync(PrepareYearsList(settings.mainPresentationsDirectory), false);
            Gui.SelectIndexAsync(MainWindow.mainWindow.cbPresentationByYearsFilter, 0);
        }
        private void FillDatesList()
        {
            PrepareDatesList(cbPresentationByYearsFilter.SelectedItem.ToString());
            //FormToGui.MainWindowFolderList_SelectItem(0);
            if (Gui.GetItemsCount(MainWindow.mainWindow.lbPresentationsDatesList) > 0)
            {
                Gui.Select(MainWindow.mainWindow.lbPresentationsDatesList, 0);
            }
        }
        private void FillDatesListAsync()
        {
            BeginInvoke(new Action(() => { FillDatesList(); }));
        }
        internal void MainWindowLoad(bool async=false)
        {
            //MessageBox.Show(updater.ServerCheck(updater.server).ToString());
            if (settings.mainPresentationsDirectory.Length > 0)
            {
                if (!async)
                {
                    FillYearsList();
                    FillDatesList();
                }
                else
                {
                    FillYearsListAsync();
                    FillDatesListAsync();
                }
            }
        }
        private void mainWindow_Load(object sender, EventArgs e)
        {
            if (settings.autoupdatePresentations)
            {
                updater = new Updater(settings.serverDirectory, settings.mainPresentationsDirectory);
                //Updater.ServerDirectoryUpdate(settings.serverDirectory, settings.mainPresentationsDirectory);
            }
            MainWindowLoad();
        }

        private void lbPresentationsDatesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListBox).Items.Count > 0)
            {
                PreparePresentataions(sender as ListBox);
            }
        }

        private void cbPresentationByYearsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareDatesList(cbPresentationByYearsFilter.SelectedItem.ToString());
            if (lbPresentationsDatesList.Items.Count > 0)
                lbPresentationsDatesList.SetSelected(0, true);
        }
        private void deputyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeputyFIO deputyFIO = new DeputyFIO();
            deputyFIO.Show();
        }
        private void presentationsNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationsNames presentationsNames = new PresentationsNames();
            presentationsNames.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (updater != null) { updater.Destroy(); }
            if (departments != null) { for (int i = 0; i < departments.Count(); i++) { departments[i].Destroy(); } }
        }
    }
}
