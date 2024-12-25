namespace SunamoGoogleMyMaps.Tests;
using TextCopy;

public class GoogleMyMapsHelperTests
{
    [Fact]
    public void CreateExportForGoogleMyMapsTest()
    {
        Dictionary<string, string> d = new()
        {
            { "A", "B" },
            { "C", "D" }
        };

        var o = GoogleMyMapsHelper.CreateExportForGoogleMyMaps(d);
        ClipboardService.SetText(o);
    }
}