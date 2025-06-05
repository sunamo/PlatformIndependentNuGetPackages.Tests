namespace RunnerStringSplit;

using SunamoStringSplit.Tests;

internal class Program
{
    private static void Main(string[] args)
    {
        SHSplitTests t = new SHSplitTests();
        //t.SplitTest();
        t.SplitByWhiteSpacesTest();
    }
}