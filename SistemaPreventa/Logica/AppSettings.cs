using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace Logica
{
    public class AppSettings
    {
        Configuration config;

        public AppSettings()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public string GetConnectionString(string Key)
        {
            return config.ConnectionStrings.ConnectionStrings[Key].ConnectionString;
        }

        public void SaveConnectionString(string Key, string Value)
        {
            config.ConnectionStrings.ConnectionStrings[Key].ConnectionString = Value;
            config.ConnectionStrings.ConnectionStrings[Key].ProviderName = "System.Data.SqlClient";
        }
    }

}
