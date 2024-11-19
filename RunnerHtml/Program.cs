
namespace RunnerHtml;
using SunamoHtml.Tests;

internal class Program
{
    static void Main(string[] args)
    {
        //HtmlAgilityHelperTests t = new HtmlAgilityHelperTests();
        ////t.PairsDdDtTest();
        //t.Test1();

        HtmlAssistantTests t = new HtmlAssistantTests();
        t.InnerTextDecodeTrimTest();

        Console.WriteLine("Finished");
        Console.WriteLine();
    }
}