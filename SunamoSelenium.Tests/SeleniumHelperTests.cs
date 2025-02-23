using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace SunamoSelenium.Tests;

public class SeleniumHelperTests
{
    ILogger logger = NullLogger.Instance;

    [Fact]
    public async Task InitDriverTest()
    {
        var d = await SeleniumHelper.InitDriver(logger, @"D:\pa\_dev\edgedriver_win64\msedgedriver.exe");

    }
}