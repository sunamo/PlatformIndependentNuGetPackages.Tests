using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoWinStd.Tests;
public class PHWinTests
{
    ILogger logger = NullLogger.Instance;

    [Fact]
    public void OpenFolderInTotalcmdTest()
    {
        PHWin.OpenFolderInTotalcmd(logger, @"D:\_Test\ConsoleApp1\ConsoleApp1\RenameBankTransactionListing\");
    }

    [Fact]
    public void CodeInsiderTest()
    {
        PHWin.CodeInsider(logger, @"C:\Users\r\AppData\Roaming\Code - Insiders\User\settings.json");
    }

    [Fact]
    public void CodeTest()
    {
        PHWin.Code(logger, @"C:\Users\r\AppData\Roaming\Code - Insiders\User\settings.json");
    }
}
