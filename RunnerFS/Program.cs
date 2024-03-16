using SunamoFileSystem.Tests;

namespace RunnerFS;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        FSTests fs = new FSTests();
        fs.GetFilesTest();
    }
}
