using TextCopy;

namespace SunamoGoogleMyMaps.Tests;

public class GoogleMyMapsHelperTests
{
    [Fact]
    public void CreateExportForGoogleMyMapsTest()
    {
        Dictionary<string, string> d = new Dictionary<string, string>();
        d.Add("A", "B");
        d.Add("C", "D");

        var o = GoogleMyMapsHelper.CreateExportForGoogleMyMaps(d);
        ClipboardService.SetText(o);
    }
}