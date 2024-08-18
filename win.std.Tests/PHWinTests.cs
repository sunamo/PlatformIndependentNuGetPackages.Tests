namespace SunamoWinStdTests;

[TestClass]
public class PHWinTests
{
    [TestMethod]
    public void OpenInBrowserTest()
    {
        PHWin.AddBrowser();
        PHWin.OpenInBrowser("https://www.cooljobs.eu/cz/php/35134");
    }

    [TestMethod]
    public async void CodiumTest()
    {
        var path = @"C:\a.txt";
        await File.WriteAllTextAsync(path, "abc");
        await PHWin.Codium(path);
    }
}
