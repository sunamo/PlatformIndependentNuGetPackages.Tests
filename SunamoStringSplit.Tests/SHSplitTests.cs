namespace SunamoStringSplit.Tests;

public class SHSplitTests
{
    [Fact]
    public void SplitMoreTest()
    {
        var ch = " "[0];
        var actual = SHSplit.SplitMore(" 63 m² ", " ");
    }
}