using Serilog;

namespace AntiAircraftGun
{
    public static class Logger
    {
        public static void ConfigureLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("log.txt")
                .MinimumLevel.Debug()
                .CreateLogger();
        }
    }
}
