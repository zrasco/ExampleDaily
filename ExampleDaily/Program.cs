using Serilog;
using System.Reflection;

[assembly: AssemblyVersion("1.0.*")]

namespace ExampleDaily
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get our assembly version in the form of (Major.Minor.Daily.Revision)
            string version = Assembly.GetEntryAssembly().GetName().Version.ToString();

            // Set up Serilog to log to console
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();

            // Log.<LogLevel> will now print to the console
            Log.Information($"This is our example daily build program! Current version: {version}");
        }
    }
}