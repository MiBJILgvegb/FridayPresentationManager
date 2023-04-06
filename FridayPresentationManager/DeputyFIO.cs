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
    public partial class DeputyFIO : Form
    {
        public DeputyFIO()
        {
            InitializeComponent();
            InitializePreviosSettings();
        }
        private void InitializePreviosSettings()
        {
            for(int i=0;i< MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.Count;i++)
            //foreach (var nameToRealFIO in MainWindow.mainWindow.varNamesToRealFIO)
            {
                this.Controls["tb"+ MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Key+"_FIO"].Text= MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Value;
                this.Controls["tbFirstDeputyOf" + MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Key+"_FIO"].Text= MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Value;
                this.Controls["tbDeputyOf" + MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Key+"_FIO"].Text= MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Value;
            }
        }
        private void SaveInfo()
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            for(int i=0;i<MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.Count;i++)
            {
                INI.Write(Consts.configSectionsName_deputyfio, MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Key, this.Controls["tb" + MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Key + "_FIO"].Text);
                INI.Write(Consts.configSectionsName_firstdeputyfio, MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Key, this.Controls["tbFirstDeputyOf" + MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Key + "_FIO"].Text);
                INI.Write(Consts.configSectionsName_deputydeputyfio, MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Key, this.Controls["tbDeputyOf" + MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Key + "_FIO"].Text);

                MainWindow.mainWindow.varDepartmentsNamesToDeputyNames[MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Key] = this.Controls["tb" + MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Key + "_FIO"].Text;
                MainWindow.mainWindow.varFirstDeputyDeputyNames[MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Key] = this.Controls["tb" + MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Key + "_FIO"].Text;
                MainWindow.mainWindow.varDeputyDeputyNames[MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Key] = this.Controls["tb" + MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Key + "_FIO"].Text;
            }
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
            Close();
        }
        private void DeputyFIOChange(TextBox textBox)
        {
            string dictKey = textBox.Name.Substring(2, textBox.Name.IndexOf('_') - 2);

            MainWindow.mainWindow.varDepartmentsNamesToDeputyNames[dictKey] = textBox.Text;
        }
        private void tbDeputyFIO_TextChanged(object sender, EventArgs e)
        {
            DeputyFIOChange(sender as TextBox);
        }
    }
}
