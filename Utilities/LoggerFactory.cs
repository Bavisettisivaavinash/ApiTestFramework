using Serilog;

namespace ApiTestFramework.Utilities
{
    public static class LoggerFactory
    {
        public static ILogger CreateLogger()
        {
            return new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }
    }
}