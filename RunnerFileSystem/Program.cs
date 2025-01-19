using SunamoFileSystem;
using SunamoFileSystem.Tests;

namespace RunnerFileSystem;

internal class Program
{
    static void Main(string[] args)
    {
        FSTests t = new FSTests();
        //t.RenameDirectoryTest();
        //t.DeleteAllEmptyDirectoriesTest(false);
        //t.MoveDirectoryNoRecursiveTest();
        t.CombineTest();
    }
}
