using iniFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FridayPresentationManager
{
    public class Department
    {
        internal string name { get; set; }
        string fullName { get; set; }
        string imagesDirectory { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "images");
        string presentationsPath { get; set; } = MainWindow.mainWindow.currentPresentationsPath;

        Presentation presentation;

        internal Person departmentHead;
        internal Person firstDeputy;
        internal Person deputy;

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
        private ToolStripMenuItem CreateToolStripItem(string name, string text,Image photo, EventHandler eventHandler)
        {
            ToolStripMenuItem toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            toolStripMenuItem.Image = photo;
            toolStripMenuItem.Name = "tsmi" + name;
            toolStripMenuItem.Size = new System.Drawing.Size(175, 25);
            toolStripMenuItem.Text = text;
            toolStripMenuItem.Click += eventHandler;

            return toolStripMenuItem;
        }
        private void TSMIMouseEventHandler(ToolStripMenuItem sender)
        {
            Person person= this.departmentHead;
            Person tsmiPerson1= this.firstDeputy;
            Person tsmiPerson2= this.deputy;
            if((sender as ToolStripMenuItem).Name.Contains(Consts.departmentPersonTitle_firstDeputy))
            { 
                person = this.firstDeputy;
                tsmiPerson1 = this.departmentHead;
            }
            else if((sender as ToolStripMenuItem).Name.Contains(Consts.departmentPersonTitle_deputy)) 
            { 
                person = this.deputy;
                tsmiPerson2 = this.departmentHead;
            }
            /*else 
            { 
                person = this.departmentHead;
                tsmiPerson1 = this.firstDeputy;
                tsmiPerson2 = this.deputy;
            }*/
            person.DrawPhoto(this.avatarPB);
            this.PrepareToolTip(this.fullName + "\r\n" + person.fio);

            this.contextMenuStrip.Items.Clear();

            ToolStripMenuItem item = CreateToolStripMenuItem(tsmiPerson1);

            //ToolStripMenuItem item = CreateFirstDeputyToolStripMenuItem();
            if (item != null) { this.contextMenuStrip.Items.Add(item); }

            item = CreateToolStripMenuItem(tsmiPerson2);
            if (item != null) { this.contextMenuStrip.Items.Add(item); }

            this.avatarPB.ContextMenuStrip = contextMenuStrip;
        }
        private void TSMI_MouseClick(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Left)
            {
                TSMIMouseEventHandler(sender as ToolStripMenuItem);
            }
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
            string imagePath = this.GetINIInfo(Consts.configSectionsName_path, Consts.configKeysName_imagesFolder);
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
        private ToolStripMenuItem CreateToolStripMenuItem(Person person)
        {
            if (person.fio.Length > 0) { return CreateToolStripItem(this.name + person.title, person.fio, person.photo, new System.EventHandler(this.TSMI_MouseClick)); }
            else return null;
        }
        //=========================================================================
        private void PrepareToolTip(string tooltipText)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(this.avatarPB, tooltipText);
        }
        private void PrepareContextMenuStrip(Person first,Person second)
        {
            this.contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Name = "cmsPB" + this.name;
            contextMenuStrip.Size = new System.Drawing.Size(60, 4);

            ToolStripMenuItem item = CreateToolStripMenuItem(first);

            //ToolStripMenuItem item = CreateFirstDeputyToolStripMenuItem();
            if (item != null) { this.contextMenuStrip.Items.Add(item); }

            item = CreateToolStripMenuItem(second);
            if (item != null) { this.contextMenuStrip.Items.Add(item); }

            this.avatarPB.ContextMenuStrip = contextMenuStrip;
        }
        //=========================================================================
        public Department(string name,Control control) 
        { 
            this.name = name;
            this.departmentControl= control;
            this.fullName=this.GetFullDepartmenName();
            this.imagesDirectory = GetImagesPath();

            this.avatarPB = this.departmentControl.Controls["pb" + this.name] as PictureBox;

            this.departmentHead = new Person(GetHeadFIO(),Consts.departmentPersonTitle_head,this.imagesDirectory);
            this.departmentHead.DrawPhoto(this.avatarPB);
            this.firstDeputy = new Person(GetFirstDeputyFIO(),Consts.departmentPersonTitle_firstDeputy,this.imagesDirectory);
            this.deputy = new Person(GetDeputyFIO(),Consts.departmentPersonTitle_deputy,this.imagesDirectory);

            this.PrepareToolTip(this.fullName+"\r\n"+this.departmentHead.fio);
            this.PrepareContextMenuStrip(this.firstDeputy, this.deputy);

            this.presentation = new Presentation(this.presentationsPath, this.GetPresentationName(), this.departmentControl.Controls["pb" + this.name + "Marker"] as PictureBox);
            this.avatarPB.Click += new System.EventHandler(this.presentation.Open);
        }
        ~Department()
        {
            this.departmentHead = null;
            this.firstDeputy = null;
            this.deputy = null;
            this.avatarPB.Click -= new System.EventHandler(this.presentation.Open);
            this.presentation = null;
            this.avatarPB = null;
            this.imagesDirectory = null;
            this.fullName = null;
            this.departmentControl = null;
            this.name = null;
        }
    }
}
