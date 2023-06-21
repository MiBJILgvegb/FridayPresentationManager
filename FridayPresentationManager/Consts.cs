using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayPresentationManager
{
    internal class Consts
    {
        internal readonly static string[] presentationEXTs = { ".pptx",".ppt" };
        internal readonly static string imagesEXT = ".png";

        internal readonly static string imagesDefaultPath = "images";
        internal readonly static string imagesDefaultPhoto = "_default" /*+ imagesEXT*/;
        internal readonly static string imagesErrorPhoto = "err" /*+ imagesEXT*/;
        internal readonly static string imagesCurrentPhoto = "cur" /*+ imagesEXT*/;
        internal readonly static string imagesOKPhoto = "ok" /*+ imagesEXT*/;

        internal readonly static string iniConfigFileName = "config.ini";
        internal readonly static string configSectionsName_departmentslist = "departmentslist";
        internal readonly static string configSectionsName_departmenfullname = "departmenfullname";
        internal readonly static string configSectionsName_deputyfio = "deputyfio";
        internal readonly static string configSectionsName_firstdeputyfio = "firstdeputyfio";
        internal readonly static string configSectionsName_deputydeputyfio = "deputydeputyfio";
        internal readonly static string configSectionsName_presentationsNames = "presentationsNames";
        internal readonly static string configSectionsName_presentationsExts = "presentationsExts";

        internal readonly static string configSectionsName_path = "path";
        internal readonly static string configKeysName_presentationFolder = "presentationFolder";
        internal readonly static string configKeysName_imagesFolder = "imagesFolder";
        
        internal readonly static string configKeysName_departmentfullname = "fullname";
        internal readonly static string configKeysName_departmentheadfio = "headfio";
        internal readonly static string configKeysName_departmentfirstdeputyfio = "firstdeputyfio";
        internal readonly static string configKeysName_departmentdeputyfio = "deputyfio";
        internal readonly static string configKeysName_departmentpresentationname = "presentationname";

        internal readonly static string _errorNoPresentationsFound = "Презентаций не найдено";
        internal readonly static string _presentationStatusERR = "err";
        internal readonly static string _presentationStatusCUR = "cur";
        internal readonly static string _presentationStatusOK = "ok";

        internal readonly static string[] departmentsNames = { "DeputyOfCityDistrict", "DeputyOfPropertyRelations", "DeputyOfSecurityCouncil", "DeputyOfJKH", "DeputyOfAKR", "DeputyOfSocialDevelopment", "DeputyOfEconomicDevelopment", "DeputyOfFinancePolicy", "DeputyOfAPK", "MCU", "EDDS" };
        
        internal static Dictionary<string,string> departmentsNamesToDeputyPhotosName= new Dictionary<string, string> { { departmentsNames[0], "Заместитель_по_строительству" }, { departmentsNames[1], "Начальник_департамента_имущественных_и_земельных_отношений" }, { departmentsNames[2], "Заместитель_секретарь_Совета_безопасности" }, { departmentsNames[3], "Заместитель_по_жилищно_коммунальному_хозяйству" }, { departmentsNames[4], "Начальник_департамента_по_организационно_аналитической_и_кадровой_работе" }, { departmentsNames[5], "Заместитель_по_социальному_развитию" }, { departmentsNames[6], "Заместитель_по_экономическому_развитию" }, { departmentsNames[7], "Начальник_департамента_финансов_и_бюджетной_политики" }, { departmentsNames[8], "Начальник_департамента_агропромышленного_комплекса_и_развития_сельских_территорий" }, { departmentsNames[9], "МЦУ" }, { departmentsNames[10], "ЕДДС" } };
    }
}
