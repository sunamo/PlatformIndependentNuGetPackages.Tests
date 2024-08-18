using System.Text;

namespace SunamoGetFiles.Tests;

public class SHGetFilesTests
{
    [Fact]
    public void GetFilesTest()
    {
        List<List<string>> r = new List<List<string>>();

        var d = DriveInfo.GetDrives();
        foreach (var item in d)
        {
            r.Add(FSGetFiles.GetFilesEveryFolder(item.RootDirectory.FullName, "*", SearchOption.AllDirectories));
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
}