
namespace RunnerHtml;
using SunamoHtml.Tests;

internal class Program
{

    static void Main(string[] args)
    {
        MainAsync(args).GetAwaiter().GetResult();
    }

    static async Task MainAsync(string[] args)
    {
        HtmlAgilityHelperTests t = new HtmlAgilityHelperTests();
        //t.PairsDdDtTest2();
        await t.CreateHtmlDocumentTest();
        //t.Test1();
        //await t.NodesWithAttrTest();

        //HtmlAssistantTests t = new HtmlAssistantTests();
        //t.InnerTextDecodeTrimTest();



        Console.WriteLine("Finished");
        Console.WriteLine();
    }
}