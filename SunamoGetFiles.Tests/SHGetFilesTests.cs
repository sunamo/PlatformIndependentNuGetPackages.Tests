using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using SunamoGetFiles._public.SunamoArgs;
using System.Text;

namespace SunamoGetFiles.Tests;

public class SHGetFilesTests
{
    public void GetFoldersEveryFolderTest()
    {
        //var d = FSGetFiles.GetFilesEveryFolder(@"E:\vs\Projects\_WhenNeedToEditAllCorruptedSlns\CommandsToAllCsFiles.Cmd\", "*.cs", true);

        var f = FSGetFiles.GetFilesEveryFolder(LoggerDummy.Instance, @"E:\vs\Projects\PlatformIndependentNuGetPackages\SunamoExceptions\", "*.cs", true, new SunamoGetFiles._public.SunamoArgs.GetFilesEveryFolderArgs { ExcludeGeneratedCodeFolders = true });

        //var f = FSGetFiles.GetFilesEveryFolder(@"E:\vs\Projects\", "*.cs", true, new SunamoGetFiles._public.SunamoArgs.GetFilesEveryFolderArgs { IgnoreFoldersWithName = ["obj", "node_modules", ".git", ".vs"], Logger = LoggerDummy.Instance });
    }

    [Fact]
    public void GetFilesTest()
    {
        List<List<string>> r = new List<List<string>>();

        var d = DriveInfo.GetDrives();
        foreach (var item in d)
        {
            r.Add(FSGetFiles.GetFilesEveryFolder(LoggerDummy.Instance, item.RootDirectory.FullName, "*", SearchOption.AllDirectories));
        }

        StringBuilder sb = new StringBuilder();

        foreach (var item in r)
        {
            //foreach (var item2 in item)
            //{
            //    sb.AppendLine(item2);
            //}
            sb.AppendLine(item.Count.ToString());
            sb.AppendLine();
            sb.AppendLine();
        }

        File.WriteAllText(@"D:\a.txt", sb.ToString());
    }

    ILogger logger = NullLogger.Instance;

    [Fact]
    public void GetFilesEveryFolderTest()
    {
        //var d = FSGetFiles.GetFilesEveryFolder(NullLogger.Instance, @"E:\vs\Projects\PlatformIndependentNuGetPackages\SunamoThreading\", "Sess.cs", true, new GetFilesEveryFolderArgs { ExcludeGeneratedCodeFolders = true });

        var d = FSGetFiles.GetFilesEveryFolder(logger, @"E:\vs\Projects\sunamo.net\Clients\src", "*.js;*.cjs", true ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly, new GetFilesEveryFolderArgs { ExcludeGeneratedCodeFolders = true });
    }
}