using SunamoGitConfig.Tests;

namespace RunnerGitConfig;

internal class Program
{
    static void Main(string[] args)
    {
        var t = new GitConfigFileHelperTests();
        t.ParseTest();
    }
}
