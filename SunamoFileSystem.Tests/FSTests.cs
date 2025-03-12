namespace SunamoFileSystem.Tests;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using SunamoFileSystem.Enums;
using System.IO.Compression;

public class FSTests
{
    ILogger logger = NullLogger.Instance;

    [Fact]
    public void MoveFileTest()
    {
        FS.MoveFile(logger, @"D:\_Test\ConsoleApp1\ConsoleApp1\RenameBankTransactionListing\24-11p.pdf", @"D:\Drive\Finance\Banks transactions listing\_2024\Uni\Uni_2024_11.pdf\", FileMoveCollisionOption.Overwrite);
    }

    [Fact]
    public void CombineTest()
    {
        const string bp = @"D:\_Test\ConsoleApp_MergeAfterNugets\PeopleForEveryDay\";
        var actual = FS.Combine(bp, "12");

        Assert.Equal(bp + "12\\", actual);
    }

    [Fact]
    public void GetFilesTest()
    {
        //var d = FSGetFiles.GetFilesEveryFolder(logger, @"E:\vs\Projects\PlatformIndependentNuGetPackages2\_\", "*.cs", SearchOption.AllDirectories, new GetFilesEveryFolderArgs { excludeFromLocationsCOntains = new List<string>([@"\obj\", "de_mo"]) });
    }

    [Fact]
    public void InsertBetweenFileNameAndPathTest()
    {
        var r = FS.InsertBetweenFileNameAndPath("a", null, "_");

    }

    [Fact]
    public void MoveDirectoryNoRecursiveTest()
    {
        var bp = @"D:\_Test\PlatformIndependentNuGetPackages\SunamoFileSystem\MoveDirectoryNoRecursiveTest\";

        var sourceZip = bp + "MoveDirectoryNoRecursiveTest.zip";
        if (!File.Exists(sourceZip))
        {
            throw new Exception($"{sourceZip} not exists!");
        }

        Directory.Delete(bp + "From", true);
        Directory.Delete(bp + "To", true);

        ZipFile.ExtractToDirectory(sourceZip, Path.GetDirectoryName(sourceZip));

        FS.MoveDirectoryNoRecursive(logger, bp + @"From\", bp + @"To\", DirectoryMoveCollisionOption.Overwrite, FileMoveCollisionOption.ThrowEx);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void DeleteAllEmptyDirectoriesTest(bool b)
    {
        // Jen takhle to funguje. Extrahovat tím že se složka sama vytvoří nejde.
        var path = @"D:\_Test\PlatformIndependentNuGetPackages\SunamoFileSystem\DeleteAllEmptyDirectoriesTest.zip";
        var p2 = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path));

        // extract pomocí System.IO.Compression
        ZipFile.ExtractToDirectory(path, p2);

        FS.DeleteAllEmptyDirectories(p2, b, ".stfolder");
    }

    [Fact]
    public void RenameDirectoryTest()
    {
        FS.RenameDirectory(logger, @"D:\Downloads\PlatformIndependentNuGetPackages-7154fb035791e4817f3849c0d68d403e3658e756\", "PlatformIndependentNuGetPackages-7154fb035791e4817f3849c0d68d403e3658e756", Enums.DirectoryMoveCollisionOption.Overwrite, Enums.FileMoveCollisionOption.Overwrite);
    }
}