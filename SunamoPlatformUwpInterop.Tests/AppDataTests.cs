
using SunamoPlatformUwpInterop.AppData;

namespace SunamoPlatformUwpInterop.Tests;

public class AppDataTests //: ProgramShared
{
    [Fact]
    public void Test1()
    {
        ThisApp.Name = "Test";
        //CreatePathToFiles(AppData.AppData.ci.GetFileString);

        AppData.AppData.ci.CreateAppFoldersIfDontExists(new SunamoPlatformUwpInterop.Args.CreateAppFoldersIfDontExistsArgs { });


    }
}