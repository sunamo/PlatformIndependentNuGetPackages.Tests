//using SunamoInit;

using SunamoCollections.Tests._sunamo;

namespace SunamoCollections.Tests;

public class CATests
{
    [Fact]
    public void RemoveStartingWithTest()
    {
        //InitHelper.FileIO();
        //InitHelper.Bts();
        //InitHelper.Ca();

        var l = SHGetLines.GetLines(@"a
#b
c");
        CA.RemoveStartingWith("#", l);
    }

    [Fact]
    public void CompareListResultTest()
    {
        var both = new List<string>();
        var d = CA.CompareListResult(true, "First", "Second", "nameOfSolution", new List<string>(["a", "c"]), new List<string>(["a", "d"]), both);


    }
}
