using SunamoCl.SunamoCmd.Essential;
using SunamoWinStd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoCl.Tests.SunamoCmd.Essential;
public class CmdAppTests
{
    public async Task WaitForSaving()
    {
        await CmdApp.WaitForSaving(@"D:\_Test\PlatformIndependentNuGetPackages\SunamoCl\WaitForSaving.txt", PHWin.Code);
    }
}
