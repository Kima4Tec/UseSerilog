using Serilog;
using Serilog.Sinks;

namespace UseSerilog
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            Log.Information("Hello, Serilog!");

            Log.Information("This is an informational message.");
            Log.Warning("This is a warning message.");
            Log.Error("This is an error message.");

            Log.CloseAndFlush();
        }
    }
}
