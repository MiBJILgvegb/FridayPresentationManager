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
        string name;
        string fullName;
        string imagesDirectory = Path.Combine(Directory.GetCurrentDirectory(), "images");
        protected string presentationsPath = MainWindow.mainWindow.currentPresentationsPath;

        Presentation presentation;

        Person deputy;
        Person firstDeputyOfDeputy;
        Person deputyOfDeputy;

        Control departmentControl;
        PictureBox avatarPB;
        PictureBox presentationMarkerPB;
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
        //=========================================================================
        public Department(string name,Control control) 
        { 
            this.name = name;
            this.departmentControl= control;
            this.fullName=this.GetFullDepartmenName();
            this.imagesDirectory = GetImagesPath();
            this.presentation = new Presentation(this.presentationsPath, this.GetPresentationName(), this.departmentControl.Controls["pb" + this.name + "Marker"] as PictureBox);

            this.avatarPB = this.departmentControl.Controls["pb" + this.name] as PictureBox;
            /*
            if (MainWindow.mainWindow.Controls["gbDepartmentList"].Controls["pb" + this.name] != null)
            {
                this.avatarPB = MainWindow.mainWindow.Controls["gbDepartmentList"].Controls["pb" + this.name] as PictureBox;
            }
            else { this.avatarPB = null; }
            */

            this.deputy = new Person(GetHeadFIO(),this.imagesDirectory);
            this.deputy.DrawPhoto(this.avatarPB);
            this.firstDeputyOfDeputy = new Person(GetFirstDeputyFIO(),this.imagesDirectory);
            this.deputyOfDeputy = new Person(GetDeputyFIO(),this.imagesDirectory);


        }
    }
}
