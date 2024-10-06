
namespace RunnerCl;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SunamoCl;
using SunamoCl.SunamoCmd;
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

    //static void ConfigureServices(ServiceCollection services)
    //{

    //}

    static async Task MainAsync(string[] args)
    {
        //ProgramCommonTests t = new ProgramCommonTests();
        //t.ProcessArgsTest();

        p = new ProgramCommon();
        // můžu přidat přímo do dict ve ProgramCommon protože ProgramCommon.AddToAllActions přidává právě do těchto 2 dict

        var appName = "RunnerCl";

        var sp = new ServiceCollection();
        sp.AddScoped<TestContainer>();

        await CmdBootStrap.RunWithRunArgs(new SunamoCl.SunamoCmd.Args.RunArgs()
        {
            IsDebug = false,
            askUserIfRelease = true,
            ProgramSharedCreatePathToFiles = ProgramSharedCreatePathToFiles,
            AppDataCiGetFileString = GetFileString,
            //AddGroupOfActions = AddGroupOfActions,
            //args = args,
            //CatchUnhandledException = false,
            //runInDebug = RunInDebugAsync,
            ServiceCollection = sp,
            LoadFromAppsettingsJson = true,
            categoryNameLogger = "Any",
            IsLoggingToConsole = true
            // V normální aplikaci bych importoval SunamoLogging
            //FileLoggerProvider = FileLoggerProvider.DefaultDirectory(appName),
            //IsLoggingToConsole = true,
            //ConfigureServices =

            //pAllActions = p.allActions,
            //groupsOfActionsFromProgramCommon = p.groupsOfActions,
            //pAllActionsAsync = p.allActionsAsync
        });

        var s = sp.BuildServiceProvider();

        var logger = s.GetRequiredService<ILogger>();
        logger.LogTrace("From main trace");
        logger.LogDebug("From main debug");
        logger.LogError("From main error");



        var tc = s.GetRequiredService<TestContainer>();
        tc.A();



        Console.WriteLine("Finished");
        Console.ReadLine();
    }

    static async Task RunInDebugAsync()
    {
        CmdAppTests t = new CmdAppTests();
        await t.WaitForSaving();



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