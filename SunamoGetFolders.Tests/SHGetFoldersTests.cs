using System.Diagnostics;
using System.Text;

namespace SunamoGetFolders.Tests;

public class SHGetFoldersTests
{
    [Fact]
    public void GetFoldersTest2()
    {
        var f = FSGetFolders.GetFoldersEveryFolder(@"D:\_Test\", $"*{"PlatformIndependentNuGetPackages"}*");
    }

    [Fact]
    public void GetFoldersTest()
    {
        List<List<string>> r = new List<List<string>>();

        var d = DriveInfo.GetDrives();
        foreach (var item in d)
        {
            r.Add(FSGetFolders.GetFoldersEveryFolder(item.RootDirectory.FullName, "*", new Args.GetFoldersEveryFolderArgs { followJunctions = false }));
        }

        StringBuilder sb = new StringBuilder();

        foreach (var item in r)
        {
            foreach (var item2 in item)
            {
                sb.AppendLine(item2);
            }
            sb.AppendLine();
            sb.AppendLine();
        }

        File.WriteAllText(@"D:\a.txt", sb.ToString());
    }
}