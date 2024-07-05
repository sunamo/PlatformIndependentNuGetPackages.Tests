using SunamoPS.Tests;

namespace RunnerPS;

internal class Program
{
    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    static async Task MainAsync(string[] args)
    {
        PowershellRunnerTests t = new PowershellRunnerTests();
        await t.InvokeInFolderTest();
    }
}
