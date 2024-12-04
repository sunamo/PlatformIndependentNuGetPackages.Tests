using SunamoStringSplit.Tests;

namespace RunnerStringSplit;

internal class Program
{
    private static void Main(string[] args)
    {
        SHSplitTests t = new SHSplitTests();
        //t.SplitMoreTest();
        t.SplitByWhiteSpacesTest();
    }
}