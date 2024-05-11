namespace Runner;

public class Program
{
    static void Main(string[] args)
    {
        //CsProjInstanceTests csProjInstanceTests = new CsProjInstanceTests();
        //csProjInstanceTests.AddSunamoSharedPlusOtherAndThenAddAnother_EveryMustBeUnique();

        PHWinTests pHWinTests = new PHWinTests();
        //pHWinTests.OpenInBrowserTest();
        //pHWinTests.CodiumTest();

        //CATests ca = new CATests();
        //ca.CompareListResultTest();

        CAGTests cag = new CAGTests();
        //cag.CompareListTest();

        FSTests fs = new FSTests();
        fs.GetFilesTest();
    }
}
