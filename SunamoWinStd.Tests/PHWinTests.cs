using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunamoWinStd.Tests;
public class PHWinTests
{
    [Fact]
    public void OpenFolderInTotalcmdTest()
    {
        PHWin.OpenFolderInTotalcmd(@"D:\_Test\ConsoleApp1\ConsoleApp1\RenameBankTransactionListing\");
    }
}
