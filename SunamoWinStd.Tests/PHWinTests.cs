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


}
