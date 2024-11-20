
namespace RunnerCl;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SunamoCl;
using SunamoCl.SunamoCmd;
using SunamoCl.SunamoCmd.Args;
using SunamoCl.SunamoCmd.Helpers;
using SunamoCl.SunamoCmdArgs_Cmd;
using SunamoCl.Tests._sunamo;
using SunamoCl.Tests.SunamoCmd.Essential;
using SunamoCl.Tests.SunamoCmdArgs_Cmd;
using SunamoLogging.FileLogger;

internal partial class Program
{
    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    public static Task ProgramSharedCreatePathToFiles(Func<string, string, string> getFile)
    {
        return Task.CompletedTask;
    }

    static string GetFileString(string a, string b)
    {
        return "";
    }

    private static Dictionary<string, Func<Task<Dictionary<string, object>>>> AddGroupOfActions()
    {
        Dictionary<string, Func<Task<Dictionary<string, object>>>> groupsOfActions = new()
        {
            { "Dating", Dating }
        };

        return groupsOfActions;
    }

    static ProgramCommon p;

    static ServiceCollection serviceCollection { get; set; } = new ServiceCollection();

    static async Task MainAsync(string[] args)
    {


        //ProgramCommonTests t = new ProgramCommonTests();
        //t.ProcessArgsTest();

        p = new ProgramCommon();
        // můžu přidat přímo do dict ve ProgramCommon protože ProgramCommon.AddToAllActions přidává právě do těchto 2 dict

        var appName = "RunnerCl";


        serviceCollection.AddScoped<TestContainer>();

        await CmdBootStrap.RunWithRunArgs(new RunArgs()
        {
            ServiceCollection = serviceCollection,
            categoryNameLogger = appName,
            //IsLoggingToConsole = true,
            //askUserIfRelease = true,

            ProgramSharedCreatePathToFiles = ProgramSharedCreatePathToFiles,
            //AppDataCiGetFileString = GetFileString,
            AddGroupOfActions = AddGroupOfActions,
            ////args = args,
            ////CatchUnhandledException = false,
            ////runInDebug = RunInDebugAsync,
            //ServiceCollection = serviceCollection,
            //LoadFromAppsettingsJson = true,
            //categoryNameLogger = "Any",
            IsLoggingToConsole = true,
            FileLoggerProvider = FileLoggerProvider.DefaultDirectory(appName),
            runInDebug = RunInDebugAsync,
            args =
#if DEBUG
            ["TestTest"],
#else
args,
#endif


            IsDebug =
#if DEBUG
            false
#else
false
#endif

            // V normální aplikaci bych importoval SunamoLogging
            //FileLoggerProvider = FileLoggerProvider.DefaultDirectory(appName),
            //IsLoggingToConsole = true,
            //ConfigureServices =

            //pAllActions = p.allActions,
            //groupsOfActionsFromProgramCommon = p.groupsOfActions,
            //pAllActionsAsync = p.allActionsAsync
        });

        Console.WriteLine("Finished");
        Console.ReadLine();
    }

    static async Task RunInDebugAsync()
    {
        await Task.Delay(1);
        Console.WriteLine("RunInDebugAsync");

        //CmdAppTests t = new CmdAppTests();
        //await t.WaitForSaving();

        var s = serviceCollection.BuildServiceProvider();

        #region Tohle mi nefunguje. Nejsem schopen aby se mi vždy vypsali všechny 3 a teprve pak "Finished"
        /*
Nepomohlo ani aby RunInDebug vracelo string který potom dále použiji
        Občas se zbylé 2 vypíšou až po Finished
        ale to bude kódem samotného loggeru
        V mém kódu to fakt není, všude kde má být await tak tam je
        nefungovalo to ani bez Task.Run
        */
        await Task.Run(() =>
        {
            var logger = s.GetRequiredService<ILogger>();


            logger.LogTrace("From main trace");
            logger.LogDebug("From main debug");
            logger.LogInformation("Info");

            logger.LogWarning("Warning");
            logger.LogError("From main error");
            logger.LogCritical("Critical");
        });

        //Toto naopak funguje bezchybně:
        Console.WriteLine("a");
        Console.WriteLine("b");
        Console.WriteLine("c");
        Console.WriteLine("d");
        #endregion



        //var tc = s.GetRequiredService<TestContainer>();
        //tc.A();

        //ProgramCommonTests t = new();
        //t.ProcessArgsTest();

        //await Task.Delay(1000);



        #region ProgressBar testing
        //var cl = new CLProgressBar();

        //Console.WriteLine("Before progress bar");
        //cl.LyricsHelper_OverallSongs(10);

        //for (int i = 0; i < 10; i++)
        //{
        //    cl.LyricsHelper_AnotherSong();
        //    await Task.Delay(1000);
        //}

        //cl.LyricsHelper_WriteProgressBarEnd(); 
        #endregion
    }
}