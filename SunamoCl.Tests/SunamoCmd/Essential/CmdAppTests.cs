using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using SunamoCl.SunamoCmd.Essential;
using SunamoWinStd;

namespace SunamoCl.Tests.SunamoCmd.Essential;
public class CmdAppTests
{
    ILogger logger = NullLogger.Instance;

    public async Task WaitForSaving()
    {
        await CmdApp.WaitForSaving(logger, @"D:\_Test\PlatformIndependentNuGetPackages\SunamoCl\WaitForSaving.txt", PHWin.Code);
    }
}
