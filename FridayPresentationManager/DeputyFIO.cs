using iniFiles;
using System;
using System.Linq;
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
            /*
            for(int i=0;i< MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.Count;i++)
            {
                this.Controls["tb"+ MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Key+"_FIO"].Text= MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Value;
                this.Controls["tbFirstDeputyOf" + MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Key+"_FIO"].Text= MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Value;
                this.Controls["tbDeputyOf" + MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Key+"_FIO"].Text= MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Value;
            }
            */

            foreach(Department department in MainWindow.mainWindow.departments)
            {
                this.Controls["tb"+department.name+"_"+Consts.configKeysName_departmentheadfio].Text= department.departmentHead.fio;
                this.Controls["tb"+department.name+"_"+Consts.configKeysName_departmentfirstdeputyfio].Text= department.firstDeputy.fio;
                this.Controls["tb"+department.name+"_"+Consts.configKeysName_departmentdeputyfio].Text= department.deputy.fio;
            }
        }
        private void SaveInfo()
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            /*
            for(int i=0;i<MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.Count;i++)
            {
                INI.Write(Consts.configSectionsName_deputyfio, MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Key, this.Controls["tb" + MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Key + "_FIO"].Text);
                INI.Write(Consts.configSectionsName_firstdeputyfio, MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Key, this.Controls["tbFirstDeputyOf" + MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Key + "_FIO"].Text);
                INI.Write(Consts.configSectionsName_deputydeputyfio, MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Key, this.Controls["tbDeputyOf" + MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Key + "_FIO"].Text);

                MainWindow.mainWindow.varDepartmentsNamesToDeputyNames[MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Key] = this.Controls["tb" + MainWindow.mainWindow.varDepartmentsNamesToDeputyNames.ElementAt(i).Key + "_FIO"].Text;
                MainWindow.mainWindow.varFirstDeputyDeputyNames[MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Key] = this.Controls["tb" + MainWindow.mainWindow.varFirstDeputyDeputyNames.ElementAt(i).Key + "_FIO"].Text;
                MainWindow.mainWindow.varDeputyDeputyNames[MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Key] = this.Controls["tb" + MainWindow.mainWindow.varDeputyDeputyNames.ElementAt(i).Key + "_FIO"].Text;
            }
            */

            foreach (Department department in MainWindow.mainWindow.departments)
            {
                INI.Write(department.name, Consts.configKeysName_departmentheadfio, this.Controls["tb" + department.name + "_" + Consts.configKeysName_departmentheadfio].Text);
                INI.Write(department.name, Consts.configKeysName_departmentfirstdeputyfio, this.Controls["tb" + department.name + "_" + Consts.configKeysName_departmentfirstdeputyfio].Text);
                INI.Write(department.name, Consts.configKeysName_departmentdeputyfio, this.Controls["tb" + department.name + "_" + Consts.configKeysName_departmentdeputyfio].Text);
            }
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
            MainWindow.mainWindow.PreparePresentataions(MainWindow.mainWindow.lbPresentationsDatesList);
            Close();
        }
        private void tbDeputyFIO_TextChanged(object sender, EventArgs e)
        {
            //DeputyFIOChange(sender as TextBox);
        }
    }
}
