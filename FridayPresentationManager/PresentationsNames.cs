using iniFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridayPresentationManager
{
    public partial class PresentationsNames : Form
    {
        public PresentationsNames()
        {
            InitializeComponent();
            InitializePreviosSettings();
        }
        private void InitializePreviosSettings()
        {
            /*
            for (int i = 0; i < MainWindow.mainWindow.varDeputyPresentationsNames.Count; i++)
            {
                this.Controls["tb" + MainWindow.mainWindow.varDeputyPresentationsNames.ElementAt(i).Key + "_presentationName"].Text = MainWindow.mainWindow.varDeputyPresentationsNames.ElementAt(i).Value;
            }
            */
            foreach (Department department in MainWindow.mainWindow.departments)
            {
                this.Controls["tb" + department.name + "_" + Consts.configKeysName_departmentpresentationname].Text = department.presentation.name;
            }
        }
        private void SaveInfo()
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);
            /*
            for (int i = 0; i < MainWindow.mainWindow.varDeputyPresentationsNames.Count; i++)
            {
                INI.Write(Consts.configSectionsName_presentationsNames, MainWindow.mainWindow.varDeputyPresentationsNames.ElementAt(i).Key, this.Controls["tb" + MainWindow.mainWindow.varDeputyPresentationsNames.ElementAt(i).Key + "_presentationName"].Text);

                MainWindow.mainWindow.varNamesToPresentations[MainWindow.mainWindow.varDeputyPresentationsNames.ElementAt(i).Key] = this.Controls["tb" + MainWindow.mainWindow.varDeputyPresentationsNames.ElementAt(i).Key + "_presentationName"].Text;
            }*/

            foreach (Department department in MainWindow.mainWindow.departments)
            {
                INI.Write(department.name, Consts.configKeysName_departmentpresentationname, this.Controls["tb" + department.name + "_" + Consts.configKeysName_departmentpresentationname].Text);
                //this.Controls["tb" + department.name + "_" + Consts.configKeysName_departmentpresentationname].Text = department.presentation.name;
                department.PreparePresentation();
            }
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
            Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
