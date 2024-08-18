using SunamoGetFiles.Tests;

namespace RunnerGetFiles;

internal class Program
{
    static void Main(string[] args)
    {
        SHGetFilesTests t = new SHGetFilesTests();
        t.GetFilesTest();
    }
}
