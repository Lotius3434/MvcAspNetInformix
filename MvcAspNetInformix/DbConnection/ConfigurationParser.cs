using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MvcAspNetInformix.DbConnection
{
    public class ConfigurationParser : IConfigurationParser
    {
        //private string searkeyKeyDataBase = ConfigurationManager.AppSettings["SearchKeyDataBase"];
        //private string searkeyDataBaseTable = ConfigurationManager.AppSettings["SearchKeyDataBaseTable"];
        private string ConfigurationConnect = null;
        private string NameTable = null;
        public string configurationConnect
        {
            get
            {
                return ConfigurationConnect;
            }
        }
        public string nameTable
        {
            get
            {
                return NameTable;
            }
        }

        public void ParseConfiguration()
        {
            //ConfigurationConnect = ConfigurationManager.AppSettings[searkeyKeyDataBase];
            //NameTable = ConfigurationManager.AppSettings[searkeyDataBaseTable];
            ConfigurationConnect = "Database=testbars; Host=localhost; Server=test_artem; Service=turbo1;Protocol=olsoctcp; UID=informix;Password=zcxfcnkbd;";
            NameTable = "tableusers";
        }
    }
}