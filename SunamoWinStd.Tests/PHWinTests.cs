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

    public void CodeWithLineTest()
    {
        var path = CreateTestFile();
        PHWin.Code(logger, path, true, 150);
    }

    private string CreateTestFile()
    {
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"a.txt");
        if (!File.Exists(path))
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 200; i++)
            {
                sb.AppendLine(i.ToString());
            }

            File.WriteAllText(path, sb.ToString());
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
