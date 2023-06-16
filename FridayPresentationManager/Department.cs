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
    internal class Department
    {
        string name;
        string fullName;
        string imagesDirectory = Path.Combine(Directory.GetCurrentDirectory(), "images");

        Presentation presentation;

        Person deputy;
        Person firstDeputyOfDeputy;
        Person deputyOfDeputy;

        PictureBox avatarPB;
        PictureBox presentationMarkerPB;
        //=========================================================================
        private string GetINIInfo(string key)
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            if (INI.KeyExists(this.name, key)) { return INI.ReadINI(this.name, key); }
            else { return ""; }
        }
        //=========================================================================
        private string GetFullDepartmenName()
        {
            return GetINIInfo(Consts.configKeysName_departmentfullname);
        }
        private string GetHeadFIO()
        {
            return GetINIInfo(Consts.configKeysName_departmentheadfio);
        }
        private string GetFirstDeputyFIO()
        {
            return GetINIInfo(Consts.configKeysName_departmentfirstdeputyfio);
        }
        private string GetDeputyFIO()
        {
            return GetINIInfo(Consts.configKeysName_departmentdeputyfio);
        }
        private string GetImagesPath()
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);
            if (INI.KeyExists(Consts.configSectionsName_path, Consts.configKeysName_imagesFolder)) 
            { 
                return INI.ReadINI(Consts.configSectionsName_path, Consts.configKeysName_imagesFolder); 
            }
            else { return Path.Combine(Directory.GetCurrentDirectory(), "images"); }
        }
        private string GetPresentationName()
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);
            if (INI.KeyExists(Consts.configSectionsName_path, Consts.configKeysName_presentationFolder))
            {
                return INI.ReadINI(Consts.configSectionsName_path, Consts.configKeysName_presentationFolder);
            }

            else { return ""; }
        }
        //=========================================================================
        public Department(string name) 
        { 
            this.name = name;
            this.fullName=this.GetFullDepartmenName();
            this.imagesDirectory = GetImagesPath();


            if (MainWindow.mainWindow.Controls["gbDeputyList"].Controls["pb" + this.name] != null)
            {
                this.avatarPB = MainWindow.mainWindow.Controls["gbDeputyList"].Controls["pb" + this.name] as PictureBox;
            }
            else { this.avatarPB = null; }

            this.deputy = new Person(GetHeadFIO(),this.imagesDirectory);
            this.firstDeputyOfDeputy = new Person(GetFirstDeputyFIO(),this.imagesDirectory);
            this.deputyOfDeputy = new Person(GetDeputyFIO(),this.imagesDirectory);


        }
    }
}
