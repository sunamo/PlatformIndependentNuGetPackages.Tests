using SunamoCsproj.Items;

namespace SunamoCsproj.Tests.csproj;

public class CsprojHelperTests
{
    [Fact]
    public async Task PropertyGroupItemContentTest()
    {
        //var d = await CsprojHelper.PropertyGroupItemContent(@"E:\vs\Projects\_ut2\sunamoWithoutLocalDep.Tests\SunamoCsproj.Tests\SunamoCsproj.Tests.csproj", "Description");
        var d2 = await CsprojHelper.PropertyGroupItemContent(@"E:\vs\Projects\sunamoWithoutLocalDep\SunamoCsproj\SunamoCsproj.csproj", "Description");
    }

    [Fact]
    public void ParseNamespaceFromCsFileTest()
    {
        var actual1 = CsprojHelper.ParseNamespaceFromCsFile(@"using a;

namespace c {
}", null);

        var actual2 = CsprojHelper.ParseNamespaceFromCsFile(@"using a;

namespace c;

class A{}", null);

        Assert.Equal("c", actual1.Item2);
        Assert.Equal("c", actual2.Item2);
    }

    [Fact]
    public void ItemsInItemGroupTest()
    {
        var d = CsprojHelper.ItemsInItemGroup(ItemGroupTagName.PackageReference, @"E:\vs\Projects\_WhenNeedToEditAllCorruptedSlns\CommandsToAllCsprojs.Cmd\CommandsToAllCsprojs.Cmd\CommandsToAllCsprojs.Cmd.csproj");
        var d2 = CsprojHelper.ItemsInItemGroup(ItemGroupTagName.ProjectReference, @"E:\vs\Projects\_WhenNeedToEditAllCorruptedSlns\CommandsToAllCsprojs.Cmd\CommandsToAllCsprojs.Cmd\CommandsToAllCsprojs.Cmd.csproj");

    }

    [Fact]
    public async Task RemoveDuplicatesInItemGroupTest()
    {

        var newCsprojContent = await CsprojHelper.RemoveDuplicatedProjectAndPackageReferences(@"D:\_Test\sunamoWithoutLocalDep\SunamoCsproj\DetectDuplicatedNugetPackages.csproj", null);
        await File.WriteAllTextAsync(@"E:\vs\Projects\_tests\CompareTwoFiles\CompareTwoFiles\xml\1.xml", newCsprojContent);
    }
}
