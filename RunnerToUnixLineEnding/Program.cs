using SunamoToUnixLineEnding.Tests;

namespace RunnerToUnixLineEnding;

internal class Program
{
    static void Main(string[] args)
    {
        LoadingFromFileTests t = new();
        t.DoTest();
    }
}
