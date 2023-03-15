using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iniFiles;
using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace FridayPresentationManager
{
    public partial class MainWindow : Form
    {
        public static MainWindow mainWindow;
        //public Dictionary<string, string> varNamesToRealFIO = new Dictionary<string, string> { { "DeputyOfCityDistrict", "" }, { "DeputyOfPropertyRelations", "" }, { "DeputyOfSecurityCouncil", "" }, { "DeputyOfJKH", "" }, { "DeputyOfAKR", "" }, { "DeputyOfSocialDevelopment", "" }, { "DeputyOfEconomicDevelopment", "" }, { "DeputyOfFinancePolicy", "" }, { "DeputyOfAPK", "" }, { "DeputyOfMCU", "" } };
        public Dictionary<string, string> varNamesToRealFIO = new Dictionary<string, string>();
        public Dictionary<int, string> varIntToNames = new Dictionary<int, string>();
        public Dictionary<string, string> varNamesToPresentations = new Dictionary<string, string>();

        private void InitializeINIParameters()
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            int i = 0;
            string[] realFIO;
            INI.GetPrivateProfileSection(Consts.configSectionsName_deputyfio, out realFIO);

            foreach (string currentFIO in realFIO)
            {
                string[] array = currentFIO.Split('=');
                varNamesToRealFIO[array[0]] = array[1];
                varIntToNames[i] = array[0];
                i++;
            }
        }
        internal string DictionaryGetKeyByValue(Dictionary<string, string> dict, string val)
        {
            int i = 0;
            foreach (var pair in dict)
            {
                if (pair.Value == val){ return pair.Key; }
                i++;
            }

            return null;
        }
        //============================================================================================
        internal string[] PreparePresentationList(string path)
        {
            string[] presentationsList=Directory.GetFiles(path, "*" + Consts.presentationEXT);
            //string[] presentationsList_old=Directory.GetFiles(path, "*" + Consts.presentationEXT_old);
            
            //presentationsList.Concat(presentationsList_old);

            return presentationsList;
        }
        private void CheckDeputyPresentation(string deputyName)
        {
            //varNamesToPresentations[deputyName] = presentation;
        }
        private void PreparePresentataions()
        {
            string[] presentationsList = PreparePresentationList("Z:\\Совещания\\пятничные\\2023\\03\\10");
            if (presentationsList.Count() == 0) MessageBox.Show(Consts._errorNoPresentationsFound);
            else
            {
                foreach (string presentation in presentationsList)
                {
                    string presentationName = Path.GetFileNameWithoutExtension(presentation);
                    string deputyName = DictionaryGetKeyByValue(varNamesToRealFIO,presentationName);
                    if (deputyName != null) 
                    {
                        varNamesToPresentations[deputyName] = presentation;
                        (this.Controls["gbDeputyList"].Controls["pb" + deputyName + "Marker"] as PictureBox).Image = Images.Properties.Resources.ok;
                    }
                }
            }
        }
        private void OpenPresentation(string presentationPath)
        {
            PowerPoint.Application objApp = new PowerPoint.Application();
            PowerPoint.Presentations objPresSet = objApp.Presentations;
            PowerPoint.Presentation objPres = objPresSet.Open(presentationPath);
        }
        private string GetDeputyNameFromPictureBox(PictureBox pictureBox)
        {
            return pictureBox.Name.Substring(2);
        }
        //============================================================================================
        private void DeputyPictureClick(PictureBox sender)
        {
            OpenPresentation(varNamesToPresentations[GetDeputyNameFromPictureBox(sender)]);
        }
        //============================================================================================
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

        private void lvDeputyList_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            PreparePresentataions();
        }

        private void deputyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeputyFIO deputyFIO = new DeputyFIO();
            deputyFIO.Show();
        }

        private void pbDeputy_MouseClick(object sender, MouseEventArgs e)
        {
            DeputyPictureClick(sender as PictureBox);
        }
    }
}
