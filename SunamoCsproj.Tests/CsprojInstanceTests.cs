namespace SunamoCsproj.Tests;
public class CsprojInstanceTests : SwdRepoNames
{
    [Fact]
    public async Task RemoveSingleItemGroupTest()
    {
        CsprojInstance csp = new CsprojInstance(await File.ReadAllTextAsync(@"E:\vs\Projects\sunamoWithoutLocalDep\SunamoAsync\SunamoAsync.csproj"));

        csp.RemoveSingleItemGroup("SunamoArgs", Items.ItemGroupTagName.PackageReference);
    }

    [Fact]
    public void AddSunamoSharedPlusOtherAndThenAddAnother_EveryMustBeUnique()
    {
        // Arrange

        XmlDocument xd = new XmlDocument();
        xd.LoadXml("<Project Sdk=\"Microsoft.NET.Sdk\"></Project>");

        const string SunamoShared = "SunamoShared";

        var csi = new CsprojInstance(xd);
        csi.CreateNewPackageReference(SunamoShared, "*");
        csi.CreateNewPackageReference(SunamoInterfaces, "*");

        var xml = xd.OuterXml;
        Debugger.Break();

        foreach (var item in new string[] { SunamoArgs, SunamoInterfaces })
        {
            csi.CreateNewPackageReference(item, "1");
        }

        var xml2 = xd.OuterXml;
        Debugger.Break();
        // Act

        // Assert
    }
}
