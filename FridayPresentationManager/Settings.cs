using iniFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayPresentationManager
{
    public class Settings
    {
        public string mainPresentationsDirectory { get; set; } = Directory.GetCurrentDirectory();
        public string serverDirectory { get; set; } = "";
        public string mainImagesDirectory { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "images");
        public bool autostartOpenedPresentation { get; set; } = false;
        public bool autoupdatePresentations { get; set; } = false;
        public void Destroy()
        {
            this.mainPresentationsDirectory = "";
            this.mainImagesDirectory = "";
            this.serverDirectory = "";
            this.autostartOpenedPresentation = false;
            this.autoupdatePresentations = false;
        }
        public Settings()
        {
            IniFiles INI = new IniFiles(Consts.iniConfigFileName);

            //получаем путь к корневой папке с презентациями
            if (INI.KeyExists(Consts.configSectionsName_path, Consts.configKeysName_presentationFolder))
            {
                mainPresentationsDirectory = INI.ReadINI(Consts.configSectionsName_path, Consts.configKeysName_presentationFolder);
                //tbPresentationsFolderPath.Text = mainPresentationsDirectory;
            }
            //получаем путь к серверной папке
            if (INI.KeyExists(Consts.configSectionsName_path, Consts.configKeysName_serverFolder))
            {
                serverDirectory = INI.ReadINI(Consts.configSectionsName_path, Consts.configKeysName_serverFolder);
                //tbPresentationsFolderPath.Text = mainPresentationsDirectory;
            }

            //получаем путь к папке с фотографиями
            if (INI.KeyExists(Consts.configSectionsName_path, Consts.configKeysName_imagesFolder))
            {
                mainImagesDirectory = INI.ReadINI(Consts.configSectionsName_path, Consts.configKeysName_imagesFolder);
            }

            //получаем настройку автозапуска
            if (INI.KeyExists(Consts.configSectionsName_settings, Consts.configKeysName_autostartOpenedPresentation))
            {
                autostartOpenedPresentation = INI.ReadINI(Consts.configSectionsName_settings, Consts.configKeysName_autostartOpenedPresentation).Equals("True");
            }

            //получаем настройку автосинхронизации презентаций
            if (INI.KeyExists(Consts.configSectionsName_settings, Consts.configKeysName_autoupdatePresentations))
            {
                autoupdatePresentations = INI.ReadINI(Consts.configSectionsName_settings, Consts.configKeysName_autoupdatePresentations).Equals("True");
            }
        }
    }
}
