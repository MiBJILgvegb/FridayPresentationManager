using iniFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FridayPresentationManager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        internal void SaveINIConfig(string section, string key, string value)
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            INI.Write(section, key, value);
        }
        private void bBrowsePresentationsFolder_Click(object sender, EventArgs e)
        {
            if (folderPresentationsDialog.ShowDialog() == DialogResult.OK)
            {
                tbPresentationsFolderPath.Text = folderPresentationsDialog.SelectedPath;
            }
        }
        private void bBrowseServerFolder_Click(object sender, EventArgs e)
        {
            if (folderPresentationsDialog.ShowDialog() == DialogResult.OK)
            {
                tbServerFolderPath.Text = folderPresentationsDialog.SelectedPath;
            }
        }

        private void bExplorePresentationsFolder_Click(object sender, EventArgs e)
        {
            if (tbPresentationsFolderPath.Text.Length > 0) { Process.Start(tbPresentationsFolderPath.Text); }
        }
        private void bExploreServerFolder_Click(object sender, EventArgs e)
        {
            if (tbServerFolderPath.Text.Length > 0) { Process.Start(tbServerFolderPath.Text); }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            tbPresentationsFolderPath.Text = MainWindow.mainWindow.settings.mainPresentationsDirectory;
            tbServerFolderPath.Text = MainWindow.mainWindow.settings.serverDirectory;
            cbAutostartOpenedPresentation.Checked = MainWindow.mainWindow.settings.autostartOpenedPresentation;
            cbAutoupdatePresentationsList.Checked = MainWindow.mainWindow.settings.autoupdatePresentations;
        }
        private void SaveInfo()
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            if (!MainWindow.mainWindow.settings.mainPresentationsDirectory.Equals(tbPresentationsFolderPath.Text))
            {
                MainWindow.mainWindow.settings.mainPresentationsDirectory = tbPresentationsFolderPath.Text;
                INI.Write(Consts.configSectionsName_path,Consts.configKeysName_presentationFolder, tbPresentationsFolderPath.Text);
            }
            if (!MainWindow.mainWindow.settings.serverDirectory.Equals(tbServerFolderPath.Text))
            {
                MainWindow.mainWindow.settings.serverDirectory = tbServerFolderPath.Text;
                INI.Write(Consts.configSectionsName_path,Consts.configKeysName_serverFolder, tbServerFolderPath.Text);
            }
            if (!MainWindow.mainWindow.settings.autostartOpenedPresentation.Equals(cbAutostartOpenedPresentation.Checked))
            {
                MainWindow.mainWindow.settings.autostartOpenedPresentation = cbAutostartOpenedPresentation.Checked;
                INI.Write(Consts.configSectionsName_settings, Consts.configKeysName_autostartOpenedPresentation, cbAutostartOpenedPresentation.Checked.ToString());
            }
            if (!MainWindow.mainWindow.settings.autoupdatePresentations.Equals(cbAutoupdatePresentationsList.Checked))
            {
                MainWindow.mainWindow.settings.autoupdatePresentations = cbAutoupdatePresentationsList.Checked;
                INI.Write(Consts.configSectionsName_settings, Consts.configKeysName_autoupdatePresentations, cbAutoupdatePresentationsList.Checked.ToString());
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
            bExit_Click(sender, e);
        }
    }
}
