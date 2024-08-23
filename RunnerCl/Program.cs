
namespace RunnerCl;
using SunamoCl;
using SunamoCl.SunamoCmd;
using SunamoCl.SunamoCmd.Helpers;
using SunamoCl.SunamoCmdArgs_Cmd;
using SunamoCl.Tests._sunamo;
using SunamoCl.Tests.SunamoCmdArgs_Cmd;

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

    private static Dictionary<string, Func<Task<Dictionary<string, object>>>> AddGroupOfActions()
    {
        Dictionary<string, Func<Task<Dictionary<string, object>>>> groupsOfActions = new()
        {
            { "Dating", Dating }
        };

        return groupsOfActions;
    }

    static ProgramCommon p;

    static async Task MainAsync(string[] args)
    {
        //ProgramCommonTests t = new ProgramCommonTests();
        //t.ProcessArgsTest();

        p = new ProgramCommon();
        // můžu přidat přímo do dict ve ProgramCommon protože ProgramCommon.AddToAllActions přidává právě do těchto 2 dict

        await CmdBootStrap.RunWithRunArgs(new SunamoCl.SunamoCmd.Args.RunArgs()
        {
            IsDebug = true,
            askUserIfRelease = true,
            ProgramSharedCreatePathToFiles = ProgramSharedCreatePathToFiles,
            AddGroupOfActions = AddGroupOfActions,
            args = args,
            CatchUnhandledException = false,
            runInDebug = RunInDebugAsync
            //pAllActions = p.allActions,
            //groupsOfActionsFromProgramCommon = p.groupsOfActions,
            //pAllActionsAsync = p.allActionsAsync
        });

        Console.WriteLine("Finished");
        Console.ReadLine();
    }

    static async Task RunInDebugAsync()
    {
        await Task.Delay(1000);

        var cl = new CLProgressBar();

        Console.WriteLine("Before progress bar");
        cl.LyricsHelper_OverallSongs(10);

        for (int i = 0; i < 10; i++)
        {
            cl.LyricsHelper_AnotherSong();
            await Task.Delay(1000);
        }

        cl.LyricsHelper_WriteProgressBarEnd();


    }
}