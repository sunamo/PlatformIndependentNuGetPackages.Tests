using SunamoDebugIO;
using SunamoPlatformUwpInterop.AppData;
using SunamoPlatformUwpInterop.Args;

namespace RunnerDebugIO;

internal class Program
{
    const string appName = "RunnerDebugIO";

    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    static async Task MainAsync(string[] args)
    {
        AppData.ci.CreateAppFoldersIfDontExists(new SunamoPlatformUwpInterop.Args.CreateAppFoldersIfDontExistsArgs { AppName = appName });
        await ProgramShared.CreatePathToFiles(AppData.ci.GetFileString);

        ProgramShared.Output = "Ahoj";
        ProgramShared.OutputOpen();
    }
}
