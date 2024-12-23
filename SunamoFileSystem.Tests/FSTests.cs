using Ionic.Zip;

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
        var r = FS.InsertBetweenFileNameAndPath();

    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void DeleteAllEmptyDirectoriesTest(bool b)
    {
        // Jen takhle to funguje. Extrahovat tím že se složka sama vytvoří nejde.
        var path = @"D:\_Test\PlatformIndependentNuGetPackages\SunamoFileSystem\DeleteAllEmptyDirectoriesTest.zip";
        var p2 = Path.Combine(Path.GetDirectoryName(path), "DeleteAllEmptyDirectoriesTest");
        Directory.Delete(p2, true);

        using (var zip = Ionic.Zip.ZipFile.Read(path))
        {
            Directory.CreateDirectory(p2);

            zip.ExtractAll(p2, ExtractExistingFileAction.OverwriteSilently);
        }

        FS.DeleteAllEmptyDirectories(p2, b, ".stfolder");
    }

    [Fact]
    public void RenameDirectoryTest()
    {
        FS.RenameDirectory(@"D:\Downloads\PlatformIndependentNuGetPackages-7154fb035791e4817f3849c0d68d403e3658e756\", "PlatformIndependentNuGetPackages-7154fb035791e4817f3849c0d68d403e3658e756", Enums.DirectoryMoveCollisionOption.Overwrite, Enums.FileMoveCollisionOption.Overwrite);
    }
}
