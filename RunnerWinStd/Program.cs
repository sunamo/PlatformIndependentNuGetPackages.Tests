
namespace RunnerWinStd;
using SunamoWinStd;
using SunamoWinStd.Tests;

internal class Program
{
    static void Main(string[] args)
    {
        //PHWin.ExecutableOfAllBrowsers();
        PHWinTests t = new PHWinTests();
        t.OpenFolderInTotalcmdTest();

        Console.WriteLine("Finished");
        Console.ReadLine();
    }
}