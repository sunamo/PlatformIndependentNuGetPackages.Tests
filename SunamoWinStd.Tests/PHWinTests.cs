using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace SunamoWinStd.Tests;
public class PHWinTests
{
    ILogger logger = NullLogger.Instance;

    public void CodeTest()
    {
        var path = CreateTestFile();
        PHWin.Code(logger, path, true);
    }

    private string CreateTestFile()
    {
        var path = @"C:\Users\radek.jancik\a.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Hello world");
        }

        return path;
    }

    public void CodeInsiderTest()
    {
        var path = CreateTestFile();
        PHWin.CodeInsider(logger, path, true);
    }

    public void CodiumTest()
    {
        var path = CreateTestFile();
        PHWin.Codium(logger, path, true);
    }

    [Fact]
    public void OpenFolderInTotalcmdTest()
    {
        PHWin.OpenFolderInTotalcmd(logger, @"D:\_Test\ConsoleApp1\ConsoleApp1\RenameBankTransactionListing\");
    }
}
