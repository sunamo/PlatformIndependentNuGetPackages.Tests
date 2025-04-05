namespace SunamoStringParts.Tests;
public class SHPartsTests
{
    [Fact]
    public void KeepAfterFirstTest()
    {
        var nameTrim = "1+kk 52 m²";
        var nameTrim2 = SHParts.KeepAfterFirst(nameTrim, " ");
    }

    [Fact]
    public void RemoveAfterFirstTest()
    {
        var nameTrim = "1+kk 52 m²";

        var ch = nameTrim.ToCharArray();

        var nameTrim2 = SHParts.RemoveAfterFirst(nameTrim, " ");
    }
}
