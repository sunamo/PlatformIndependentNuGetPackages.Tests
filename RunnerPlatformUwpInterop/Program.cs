using SunamoPlatformUwpInterop.Tests;

namespace RunnerPlatformUwpInterop;

internal class Program
{
    static void Main(string[] args)
    {
        AppDataTests t = new AppDataTests();
        t.ReadFileOfSettingsListTest();
    }
}
