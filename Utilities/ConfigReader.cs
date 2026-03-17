using Microsoft.Extensions.Configuration;

namespace ApiTestFramework.Utilities
{
    public static class ConfigReader
    {
        private static IConfiguration _config;

        public static void Initialize(string environment)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true);

            _config = builder.Build();
        }

        public static string GetValue(string key)
        {
            return _config[key];
        }
    }
}