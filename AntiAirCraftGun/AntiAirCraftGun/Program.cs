using Microsoft.Extensions.Configuration;
using Serilog;
namespace AntiAircraftGun
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(new ConfigurationBuilder().AddJsonFile("serilog.json").Build())
                .CreateLogger();
            ApplicationConfiguration.Initialize();
			Application.Run(new FormAntiAirCraftGunCollection());
		}
	}
}