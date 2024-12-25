
using SunamoFileSystem.Enums;
using System.IO.Compression;

namespace SunamoFileSystem.Tests;

public class FSTests
{
    [Fact]
    public void GetFilesTest()
    {
        //var d = FSGetFiles.GetFiles(@"E:\vs\Projects\PlatformIndependentNuGetPackages2\_\", "*.cs", SearchOption.AllDirectories, new GetFilesArgs { excludeFromLocationsCOntains = new List<string>([@"\obj\", "de_mo"]) });
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

        FS.MoveDirectoryNoRecursive(bp + @"From\", bp + @"To\", DirectoryMoveCollisionOption.Overwrite, FileMoveCollisionOption.ThrowEx);
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
        FS.RenameDirectory(@"D:\Downloads\PlatformIndependentNuGetPackages-7154fb035791e4817f3849c0d68d403e3658e756\", "PlatformIndependentNuGetPackages-7154fb035791e4817f3849c0d68d403e3658e756", Enums.DirectoryMoveCollisionOption.Overwrite, Enums.FileMoveCollisionOption.Overwrite);
    }
}
