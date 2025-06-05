using SunamoStringReplace.Tests;

namespace RunnerStringReplace;

internal class Program
{
    static async Task Main(string[] args)
    {
        SHReplaceTests t = new();
        await t.ReplaceAll();
    }
}
