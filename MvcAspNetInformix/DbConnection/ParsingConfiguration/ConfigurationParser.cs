using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MvcAspNetInformix.DbConnection.ParsingConfiguration
{
    public class ConfigurationParser : IConfigurationParser
    {
        private string ConfigurationConnect = null;       
        public string configurationConnect
        {
            get
            {
                return ConfigurationConnect;
            }
        }
        
        public void ParseConfiguration()
        {
            //ConfigurationConnect = ConfigurationManager.AppSettings[searkeyKeyDataBase];
            //NameTable = ConfigurationManager.AppSettings[searkeyDataBaseTable]testbars;Client RU_RU.8859-5;Database Locale=RU_RU.8859-5;
            ConfigurationConnect = "Database=newtable_users; Host=localhost; Server=test_artem; Service=turbo1;Client Locale=ru_ru.CP1251;Database Locale=RU_RU.8859-5; Protocol=olsoctcp; UID=informix;Password=zcxfcnkbd;";
            
        }
    }
}