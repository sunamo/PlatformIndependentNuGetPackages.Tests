using SunamoGoogleSheets.Tests;

namespace RunnerGoogleSheets;

internal class Program
{
    static void Main(string[] args)
    {
        SheetsHelperTests t = new SheetsHelperTests();
        //t.SwitchForGoogleSheetsTest();
        t.SwitchRowsAndColumnTest();
    }
}
