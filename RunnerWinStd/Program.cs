
namespace RunnerWinStd;
using SunamoWinStd.Tests;

internal class Program
{
    static void Main(string[] args)
    {
        //PHWin.ExecutableOfAllBrowsers();
        PHWinTests t = new PHWinTests();
        //t.OpenFolderInTotalcmdTest();

        //t.CodeTest();
        //t.CodiumTest();
        //t.CodeInsiderTest();

        t.CodiumTest();

        //t.CodeWithLineTest();

        Console.WriteLine("Finished");
        Console.ReadLine();
    }
}