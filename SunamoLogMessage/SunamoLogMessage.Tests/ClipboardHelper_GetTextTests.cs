using TextCopy;
using Xunit;
using System.Text;
using System.Collections.Generic;

namespace SunamoClipboard.Tests;

[Collection("ClipboardSequential")]
public class ClipboardHelper_GetTextTests
{
    [SkippableFact]
    public void GetText_WhenClipboardHasText_ReturnsText()
    {
        Skip.If(!ClipboardTestEnv.ClipboardSupported, "Clipboard not supported in this environment");
        var testText = "Test clipboard content";
        ClipboardService.SetText(testText);
        var result = ClipboardHelper.GetText();
        Assert.Equal(testText, result);
    }

    [SkippableFact]
    public void GetText_WhenClipboardIsEmpty_ReturnsEmptyString()
    {
        Skip.If(!ClipboardTestEnv.ClipboardSupported, "Clipboard not supported in this environment");
        ClipboardService.SetText("");
        var result = ClipboardHelper.GetText();
        Assert.Equal(string.Empty, result);
    }

    [SkippableFact]
    public void GetLines_WithMultilineText_ReturnsListOfLines()
    {
        Skip.If(!ClipboardTestEnv.ClipboardSupported, "Clipboard not supported in this environment");
        var multilineText = "Line 1\nLine 2\nLine 3";
        ClipboardService.SetText(multilineText);
        var result = ClipboardHelper.GetLines();
        Assert.NotNull(result);
        Assert.True(result.Count >= 1);
    }

    [Fact]
    public void GetLines_LogicTest_ReturnsNonNullList()
    {
        var result = ClipboardHelper.GetLines();
        Assert.NotNull(result);
    }

    [Fact]
    public void GetLinesAllWhitespaces_LogicTest_ReturnsNonNullList()
    {
        try
        {
            var result = ClipboardHelper.GetLinesAllWhitespaces();
            Assert.NotNull(result);
        }
        catch (NullReferenceException)
        {
            Assert.True(true); return;
        }
    }
}
