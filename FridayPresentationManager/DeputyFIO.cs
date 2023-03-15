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
            for(int i=0;i< MainWindow.mainWindow.varNamesToRealFIO.Count;i++)
            //foreach(var deputyPair in MainWindow.mainWindow.varNamesToRealFIO)
            {
                //MainWindow.mainWindow.varNamesToRealFIO[MainWindow.mainWindow.varIntToNames[i]]
                this.Controls["tb"+ MainWindow.mainWindow.varIntToNames[i] + "_FIO"].Text= MainWindow.mainWindow.varNamesToRealFIO[MainWindow.mainWindow.varIntToNames[i]];
            }
        }
        private void SaveInfo(Dictionary<string, string> info)
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            foreach(var fio in info)
            {
                INI.Write("deputyfio",fio.Key,fio.Value);
            }
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveInfo(MainWindow.mainWindow.varNamesToRealFIO);
            Close();
        }
        private void DeputyFIOChange(TextBox textBox)
        {
            string dictKey = textBox.Name.Substring(2, textBox.Name.IndexOf('_') - 2);

            MainWindow.mainWindow.varNamesToRealFIO[dictKey] = textBox.Text;
        }
        private void tbDeputyFIO_TextChanged(object sender, EventArgs e)
        {
            DeputyFIOChange(sender as TextBox);
        }
    }
}
