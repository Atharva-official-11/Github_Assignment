
using Microsoft.Extensions.Configuration;

namespace Collections_Hackathon_day8.Utility
{
    static class DBConnectionUtility
    {
        static IConfiguration _iConfiguration;

        static DBConnectionUtility()
        {
            GetAppSettingsFile();
        }

        private static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder() //used to build configuration object from dataSource
                        .SetBasePath(Directory.GetCurrentDirectory()) //settting the path to applications current directory
                        .AddJsonFile("AppSetting.json");//load the configuration setting from this json file
            _iConfiguration = builder.Build();//compiling configuration into Iconfiguration
        }

        public static string GetConnectionString()
        {
            return _iConfiguration.GetConnectionString("LocalConnectionString");
        }
    }
}
