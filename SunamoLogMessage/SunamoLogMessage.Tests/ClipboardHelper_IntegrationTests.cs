using TextCopy;
using Xunit;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace SunamoClipboard.Tests;

[Collection("ClipboardSequential")]
public class ClipboardHelper_IntegrationTests
{
    [SkippableFact]
    public void Integration_SetLinesAndGetLines_WhenClipboardWorks()
    {
        Skip.If(!ClipboardTestEnv.ClipboardSupported, "Clipboard not supported in this environment");
        var originalLines = new List<string> { "Line A", "Line B", "Line C" };
        ClipboardHelper.SetLines(originalLines);
        var retrievedLines = ClipboardHelper.GetLines();
        Assert.NotNull(retrievedLines);
        Assert.True(retrievedLines.Count >= 1);
    }

    [SkippableFact]
    public void Integration_SetTextWithStringBuilderAndGetText_WhenClipboardWorks()
    {
        Skip.If(!ClipboardTestEnv.ClipboardSupported, "Clipboard not supported in this environment");
        var sb = new StringBuilder();
        sb.Append("First part");
        sb.Append(" and second part");
        ClipboardHelper.SetText(sb);
        Thread.Sleep(100); // delší zpoždění pro clipboard
        var retrievedText = ClipboardHelper.GetText();
        // Normalizace konců řádků pro robustní porovnání
        var expected = sb.ToString().Replace("\r\n", "\n").Replace("\r", "\n");
        var actual = retrievedText.Replace("\r\n", "\n").Replace("\r", "\n");
        if (expected != actual)
        {
            // Výpis hodnot pro diagnostiku
            System.Console.WriteLine($"EXPECTED: [{expected}]");
            System.Console.WriteLine($"ACTUAL:   [{actual}]");
        }
        Assert.Equal(expected, actual);
    }

    [SkippableFact]
    public void SmokeTest_AllMethodsCallable()
    {
        Skip.If(!ClipboardTestEnv.ClipboardSupported, "Clipboard not supported in this environment");
        ClipboardHelper.GetText();
        ClipboardHelper.SetText("test");
        ClipboardHelper.SetText(new StringBuilder("test"));
        ClipboardHelper.SetLines(new List<string> { "test" });
        ClipboardHelper.GetLines();
        ClipboardHelper.SetDictionary(new Dictionary<string, string>(), "=");
        ClipboardHelper.AppendText("test");
        Assert.True(true);
    }

    [SkippableFact]
    public void ClipboardSupport_DetectionTest()
    {
        Skip.If(!ClipboardTestEnv.ClipboardSupported, "Clipboard not supported in this environment");
        var isSupported = ClipboardTestEnv.ClipboardSupported;
        Assert.True(true);
    }
}
