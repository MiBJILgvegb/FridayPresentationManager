using iniFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridayPresentationManager
{
    public class Department
    {
        string name { get; set; }
        string fullName { get; set; }
        string imagesDirectory { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "images");
        string presentationsPath { get; set; } = MainWindow.mainWindow.currentPresentationsPath;

        Presentation presentation;

        Person departmentHead;
        Person firstDeputy;
        Person deputy;

        Control departmentControl;
        PictureBox avatarPB;
        PictureBox presentationMarkerPB;

        ContextMenuStrip contextMenuStrip;
        //=========================================================================
        private string GetINIInfo(string key)
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            if (INI.KeyExists(this.name, key)) { return INI.ReadINI(this.name, key); }
            else { return ""; }
        }
        private string GetINIInfo(string section,string key)
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            if (INI.KeyExists(section, key)) { return INI.ReadINI(section, key); }
            else { return ""; }
        }
        private ToolStripMenuItem CreateToolStripItem(string name, string text/*, EventHandler eventHandler*/)
        {
            ToolStripMenuItem toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            //toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCut.Image")));
            toolStripMenuItem.Name = "tsmi" + name;
            toolStripMenuItem.Size = new System.Drawing.Size(175, 25);
            toolStripMenuItem.Text = text;
            //toolStripMenuItem.Click += eventHandler;

            return toolStripMenuItem;
        }
        //=========================================================================
        private string GetFullDepartmenName()
        {
            return GetINIInfo(this.name,Consts.configKeysName_departmentfullname);
        }
        private string GetHeadFIO()
        {
            return GetINIInfo(this.name, Consts.configKeysName_departmentheadfio);
        }
        private string GetFirstDeputyFIO()
        {
            return GetINIInfo(this.name, Consts.configKeysName_departmentfirstdeputyfio);
        }
        private string GetDeputyFIO()
        {
            return GetINIInfo(this.name, Consts.configKeysName_departmentdeputyfio);
        }
        private string GetImagesPath()
        {
            string imagePath = this.GetINIInfo( Consts.configSectionsName_path, Consts.configKeysName_imagesFolder);
            if (imagePath.Length == 0) { return Path.Combine(Directory.GetCurrentDirectory(), "images"); }
            else { return imagePath; }
        }
        private string GetPresentationFolder()
        {
            return this.GetINIInfo( Consts.configSectionsName_path, Consts.configKeysName_presentationFolder);
        }
        private string GetPresentationName()
        {
            return this.GetINIInfo(this.name, Consts.configKeysName_departmentpresentationname);
        }
        private ToolStripMenuItem CreateFirstDeputyToolStripMenuItem()
        {
            if (this.firstDeputy.fio.Length > 0)
            {
                return CreateToolStripItem(this.name + "FirstDeputyMenuItem", this.firstDeputy.fio);
            }
            else return null;
        }
        private ToolStripMenuItem CreateDeputyToolStripMenuItem()
        {
            if (this.deputy.fio.Length > 0)
            {
                return CreateToolStripItem(this.name + "DeputyMenuItem", this.deputy.fio);
            }
            else return null;
        }
        //=========================================================================
        private void PrepareToolTip(string tooltipText)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(this.avatarPB, tooltipText);
        }
        private void PrepareContextMenuStrip()
        {
            this.contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Name = "cmsPB" + this.name;
            contextMenuStrip.Size = new System.Drawing.Size(60, 4);

            ToolStripMenuItem[] items=new[] { new ToolStripMenuItem(),new ToolStripMenuItem()};
            ToolStripMenuItem item = CreateFirstDeputyToolStripMenuItem();
            if (item != null) { items[0] = item; }
            
            this.contextMenuStrip.Items.AddRange(new[] { CreateFirstDeputyToolStripMenuItem(), CreateDeputyToolStripMenuItem() });
            this.avatarPB.ContextMenuStrip = contextMenuStrip;
        }
        //=========================================================================
        public void ChangeAvatar()
        {

        }
        //=========================================================================
        public Department(string name,Control control) 
        { 
            this.name = name;
            this.departmentControl= control;
            this.fullName=this.GetFullDepartmenName();
            this.imagesDirectory = GetImagesPath();
            this.presentation = new Presentation(this.presentationsPath, this.GetPresentationName(), this.departmentControl.Controls["pb" + this.name + "Marker"] as PictureBox);

            this.avatarPB = this.departmentControl.Controls["pb" + this.name] as PictureBox;

            this.departmentHead = new Person(GetHeadFIO(),this.imagesDirectory);
            this.departmentHead.DrawPhoto(this.avatarPB);
            this.firstDeputy = new Person(GetFirstDeputyFIO(),this.imagesDirectory);
            this.deputy = new Person(GetDeputyFIO(),this.imagesDirectory);

            this.PrepareToolTip(this.fullName+"\r\n"+this.departmentHead.fio);
            this.PrepareContextMenuStrip();
        }
    }
}
