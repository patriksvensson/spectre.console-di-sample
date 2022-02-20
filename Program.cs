using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Spectre.Console.Cli;

namespace Sample;

public static class Program
{
    public static int Main(string[] args)
    {
        return CreateHostBuilder()
            .Build()
            .Run(args);
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureLogging(logging =>
            {
                // Configure logging
            })
            .ConfigureServices(services =>
            {
                // Register services here

                // Add command line with default command
                services.AddCommandLine<DefaultCommand>(config =>
                {
                    config.SetApplicationName("comply");
                });
            });
    }
}
