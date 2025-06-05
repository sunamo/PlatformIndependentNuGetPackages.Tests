using SunamoRegex.Tests;

namespace RunnerRegex;

internal class Program
{
    static void Main(string[] args)
    {
        //var d = new QuestionMarkTests();
        //d.b();

        var t = new RegexHelperTests();
        t.CzechAccountNumbersTest();
    }
}
