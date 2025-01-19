
namespace RunnerCl;

using Microsoft.Extensions.DependencyInjection;
using ShellProgressBar;
using SunamoCl;
using SunamoCl.SunamoCmd;
using SunamoCl.SunamoCmd.Args;
using SunamoCl.SunamoCmdArgs_Cmd;

internal partial class Program
{
    static ProgramCommon p;
    const string appName = "RunnerCl";

    static IServiceCollection Services { get; set; }
    static ServiceProvider Provider { get; set; }

    static Program()
    {
        p = new ProgramCommon();

        Services = new ServiceCollection();

        Services.AddScoped<TestContainer>();

        CmdBootStrap.AddILogger(Services, true, null, appName);
        CmdBootStrap.AddIConfiguration(Services);

        Provider = Services.BuildServiceProvider();
    }

    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    static async Task MainAsync(string[] args)
    {
        //ProgramCommonTests t = new ProgramCommonTests();
        //t.ProcessArgsTest();

        // můžu přidat přímo do dict ve ProgramCommon protože ProgramCommon.AddToAllActions přidává právě do těchto 2 dict

        await CmdBootStrap.RunWithRunArgs(new RunArgs()
        {
            ServiceCollection = Services,
            AddGroupOfActions = AddGroupOfActions,
            //AddGroupOfActions = CommandsToAllCsFiles.Cmd.Program.AddGroupOfActions,
            RunInDebugAsync = RunInDebugAsync,
            Args =
#if DEBUG
            //["TestTest"],
            [],
#else
args,
#endif


            IsDebug =
#if DEBUG
            true
#else
false
#endif
        });

        //CL.WriteLine("Finished");
        Console.ReadLine();
    }

    static async Task RunInDebugAsync()
    {
        await Task.Delay(1);
        //CL.WriteLine("RunInDebugAsync");

        //CmdAppTests t = new CmdAppTests();
        //await t.WaitForSaving();

        //LoggingInSerie();

        var tc = Provider.GetRequiredService<TestContainer>();
        tc.A();

        var options = new ProgressBarOptions
        {
            ProgressCharacter = '─',
            ProgressBarOnBottom = true,
            CollapseWhenFinished = false,
            DisplayTimeInRealTime = false
        };

        CLProgressBarWithChilds pb = new CLProgressBarWithChilds();


        RunFor10("First", options, pb);
        RunFor10("Second", options, pb);
    }

    private static void RunFor10(string message, ProgressBarOptions options, CLProgressBarWithChilds pb)
    {
        pb.LyricsHelper_OverallSongs(10, message, options);

        for (int i = 0; i < 10; i++)
        {
            pb.LyricsHelper_AnotherSong(message);
            Thread.Sleep(100);
        }

        pb.LyricsHelper_WriteProgressBarEnd();
    }

    private static void ProgressBarTesting()
    {
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

    private static void LoggingInSerie()
    {
        #region Logging test
        var s = Services.BuildServiceProvider();

        #region Tohle mi nefunguje. Nejsem schopen aby se mi vždy vypsali všechny 3 a teprve pak "Finished"
        /*
Nepomohlo ani aby RunInDebug vracelo string který potom dále použiji
        Občas se zbylé 2 vypíšou až po Finished
        ale to bude kódem samotného loggeru
        V mém kódu to fakt není, všude kde má být await tak tam je
        nefungovalo to ani bez Task.Run
        */

        //await Task.Run(() =>
        //{
        //    var logger = s.GetRequiredService<ILogger>();


        //    logger.LogTrace("From main trace");
        //    logger.LogDebug("From main debug");
        //    logger.LogInformation("Info");

        //    logger.LogWarning("Warning");
        //    logger.LogError("From main error");
        //    logger.LogCritical("Critical");
        //});

        //Toto naopak funguje bezchybně:
        Console.WriteLine("a");
        Console.WriteLine("b");
        Console.WriteLine("c");
        Console.WriteLine("d");
        #endregion
        #endregion
    }
}