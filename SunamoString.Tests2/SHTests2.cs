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
        var d = SH.ContainsCl("Search all on Google (append text)", "google append", Enums.SearchStrategy.AnySpaces, false);
        var d2 = SH.ContainsCl("Search all on Google (sites, append text) - jde použít i pro hledání např. rezervace na různých url", "google append", Enums.SearchStrategy.AnySpaces, false);
    }
}
