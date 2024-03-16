using SunamoGoogleSheets.Clipboard;

namespace SunamoGoogleSheets.Tests;

public class SheetsHelperTests
{
    [Fact]
    public void SplitFromGoogleSheetsRowTest()
    {
        var input = "a\tbc\td";

        var actual = SheetsHelper.SplitFromGoogleSheets(input);

        Assert.Equal(["a", "bc", "d"], actual);
    }

    [Fact]
    public void SplitFromGoogleSheetsRowTest2()
    {
        var input = "a\tbc\t\td";

        var actual = SheetsHelper.SplitFromGoogleSheets(input);

        Assert.Equal(["a", "bc", "d"], actual);
    }
}