using SunamoArgs;

namespace SunamoFileSystem.Tests;

public class FSTests
{
    [Fact]
    public void GetFilesTest()
    {
        var d = FS.GetFiles(@"E:\vs\Projects\sunamoWithoutLocalDep2\_\", "*.cs", SearchOption.AllDirectories, new GetFilesArgs { excludeFromLocationsCOntains = new List<string>([@"\obj\", "de_mo"]) });


    }
}