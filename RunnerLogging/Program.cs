namespace RunnerLogging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SunamoLogging.FileLogger;

internal class Program
{
    static void Main()
    {
        var sc = new ServiceCollection();
        sc.AddLogging(opt => opt.SetMinimumLevel(LogLevel.Warning));
        sc.AddSingleton(provider =>
        {
            var loggerFactory = provider.GetRequiredService<ILoggerFactory>();
            loggerFactory.AddFile("RunnerLogging");
            const string categoryName = "Any";
            return loggerFactory.CreateLogger(categoryName);
        });
        var sp = sc.BuildServiceProvider();
        var logger = sp.GetRequiredService<ILogger>();
        logger.LogCritical("END OF WORLD!");
    }
}