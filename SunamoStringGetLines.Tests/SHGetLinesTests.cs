namespace SunamoStringGetLines.Tests;

public class SHGetLinesTests
{

    /// <summary>
    /// Vytvořeno zda správně čte různé newline
    /// Zjištěno že ano, jak File tak TF
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task ReadAllLinesTest_AllN()
    {
        var path = @"D:\_Test\sunamoWithoutLocalDep\SunamoFileIO\AllNN.cs";
        var o = await File.ReadAllTextAsync(path);
        var l = SHGetLines.GetLines(o);
        //var l = await TF.ReadAllLines(path);
    }

    [Fact]
    public async Task ReadAllLinesTest_AllRn()
    {
        var bp = @"D:\_Test\sunamoWithoutLocalDep\SunamoFileIO\";
        var path = bp + "AllRnRn.cs";
        // TF.ReadAllLines vrací 26 řádků, ReadAllLinesAsync 29
        var o = await File.ReadAllTextAsync(path);
        var l = SHGetLines.GetLines(o);
        //var l = await TF.ReadAllLines(path);
    }
    //

    [Fact]
    public async Task ReadAllLinesTest_ProblematicFiles()
    {
        var path = @"E:\vs\Projects\sunamoWithoutLocalDep\SunamoLang\SunamoI18N\AppLangHelper.cs";
        // TF.ReadAllLines vrací 26 řádků, ReadAllLinesAsync 29
        var o = await File.ReadAllTextAsync(path);
        var l = SHGetLines.GetLines(o);
        //var l = await TF.ReadAllLines(path);
    }
}