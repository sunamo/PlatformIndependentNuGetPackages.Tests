namespace SunamoFileIO.Tests;

public class TFTests
{
    [Fact]
    public async Task ReadAllTextTest()
    {
        SunamoInit.InitHelper.FileIO();

        ThisApp.Name = "Test";
        //CreatePathToFiles(AppData.AppData.ci.GetFileString);

        AppData.ci.CreateAppFoldersIfDontExists(new SunamoPlatformUwpInterop.Args.CreateAppFoldersIfDontExistsArgs { });

        var d = await TF.ReadAllText(@"D:\_Test\ConsoleApp1\ConsoleApp1\ParseTableFromCoolJobs\JobOffers.html");


    }
}