namespace SunamoString.Tests2;
using SunamoString._public;
using Xunit;

public class SHTests
{
    [Fact]
    public void FirstWordWhichIsNumberTest()
    {
        var d4 = SH.FirstWordWhichIsNumber(" 85 m², pozemek 260 m²", 0);
        var d = SH.FirstWordWhichIsNumber(" 44 m² ", 1);
        var d2 = SH.FirstWordWhichIsNumber(" 44 m² ", 0);
        var d3 = SH.FirstWordWhichIsNumber("a 44 m² ", 1);


    }

    [Fact]
    public void ContainsClTest()
    {
        var d = SH.ContainsCl("Search all on Google (append text)", new StringOrStringList("google append"), Enums.SearchStrategy.AnySpaces, false);
        var d2 = SH.ContainsCl("Search all on Google (sites, append text) - jde použít i pro hledání např. rezervace na různých url", new StringOrStringList("google append"), Enums.SearchStrategy.AnySpaces, false);
        var d3 = SH.ContainsCl("TestHost2Sth3", new StringOrStringList("Test Host"), Enums.SearchStrategy.AnySpaces);
    }

    [Fact]
    public void GetTextBetweenSimpleTest()
    {
        var d = SH.GetTextBetweenSimple("\" \"", "\"", "\"");
    }
}