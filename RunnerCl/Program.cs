
namespace RunnerCl;
using SunamoCl;
using SunamoCl.SunamoCmd;
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
            IsDebug = false,
            askUserIfRelease = true,
            ProgramSharedCreatePathToFiles = ProgramSharedCreatePathToFiles,
            AddGroupOfActions = AddGroupOfActions,
            args = CollectionsHelperTo.ToArray<string>(),
            CatchUnhandledException = false,
            //runInDebug = RunI
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
    }
}