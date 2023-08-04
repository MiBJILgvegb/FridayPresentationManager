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
    }
}
