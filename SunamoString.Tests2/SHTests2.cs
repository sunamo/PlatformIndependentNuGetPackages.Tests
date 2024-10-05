using SunamoString._public;

namespace SunamoString.Tests2;

public class SHTests
{
    [Fact]
    public void FirstWordWhichIsNumberTest()
    {
        var d = SH.FirstWordWhichIsNumber(" 63 m² ", 0);
        Assert.Equal(63, d);
    }

    [Fact]
    public void ContainsClTest()
    {
        var d = SH.ContainsCl("Search all on Google (append text)", new StringOrStringList("google append"), Enums.SearchStrategy.AnySpaces, false);
        var d2 = SH.ContainsCl("Search all on Google (sites, append text) - jde použít i pro hledání např. rezervace na různých url", new StringOrStringList("google append"), Enums.SearchStrategy.AnySpaces, false);
        var d3 = SH.ContainsCl("TestHost2Sth3", new StringOrStringList("Test Host"), Enums.SearchStrategy.AnySpaces);
    }
}
