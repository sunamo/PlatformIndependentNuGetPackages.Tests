using Microsoft.Extensions.Logging.Abstractions;
using SunamoHttp.Args;
using SunamoPlatformUwpInterop._public.SunamoEnums.Enums;
using SunamoPlatformUwpInterop.AppData;
using System.Threading.Tasks;

namespace SunamoHttp.Tests;

public class HttpRequestHelperTests
{
    [Fact]
    public async Task DownloadOrReadTest()
    {
        AppData.ci.CreateAppFoldersIfDontExists(new SunamoPlatformUwpInterop.Args.CreateAppFoldersIfDontExistsArgs { AppName = "SunamoHttp.Tests" });

        var html = await HttpRequestHelper.DownloadOrRead(NullLogger.Instance, @"https://reality.idnes.cz/s/prodej/domy/okres-kutna-hora/?s-qc%5BusableAreaMin%5D=60&s-qc%5BusableAreaMax%5D=70", AppData.ci.GetFolder(AppFolders.Cache), new DownloadOrReadArgs { forceDownload = false });
    }

    [Fact]
    public async Task DownloadTest()
    {
        var html = await HttpRequestHelper.Download(NullLogger.Instance, null, "https://www.cooljobs.eu/cz/java/38016", null, @"DownloadTest.html");
    }
}
