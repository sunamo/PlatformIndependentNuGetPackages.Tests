
namespace RunnerHtml;
using SunamoHtml.Tests;

internal class Program
{
    static void Main(string[] args)
    {
        HtmlAgilityHelperTests t = new HtmlAgilityHelperTests();
        //t.PairsDdDtTest();
        t.Test1();

        Console.WriteLine("Finished");
        Console.WriteLine();
    }
}