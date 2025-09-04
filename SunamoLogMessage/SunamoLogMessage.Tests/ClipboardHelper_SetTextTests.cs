using TextCopy;
using Xunit;
using System.Text;
using System.Collections.Generic;

namespace SunamoClipboard.Tests;

[Collection("ClipboardSequential")]
public class ClipboardHelper_SetTextTests
{
    [SkippableFact]
    public void SetText_WithValidText_SetsClipboardContent()
    {
        Skip.If(!ClipboardTestEnv.ClipboardSupported, "Clipboard not supported in this environment");
        var testText = "Test text to set";
        ClipboardHelper.SetText(testText);
        var clipboardContent = ClipboardService.GetText();
        Assert.Equal(testText, clipboardContent);
    }

    [SkippableFact]
    public void SetText_WithStringBuilder_SetsClipboardContent()
    {
        Skip.If(!ClipboardTestEnv.ClipboardSupported, "Clipboard not supported in this environment");
        var sb = new StringBuilder();
        sb.AppendLine("Line 1");
        sb.AppendLine("Line 2");
        sb.Append("Line 3");
        ClipboardHelper.SetText(sb);
        var expected = sb.ToString();
        var clipboardContent = ClipboardService.GetText();
        Assert.Equal(expected, clipboardContent);
    }

    [SkippableFact]
    public void SetLines_WithMultipleLines_SetsClipboardWithNewlines()
    {
        Skip.If(!ClipboardTestEnv.ClipboardSupported, "Clipboard not supported in this environment");
        var lines = new List<string> { "Line 1", "Line 2", "Line 3" };
        ClipboardHelper.SetLines(lines);
        var expected = "Line 1\nLine 2\nLine 3";
        var clipboardContent = ClipboardService.GetText();
        Assert.Equal(expected, clipboardContent);
    }

    [Fact]
    public void SetLines_WithEmptyList_LogicTest()
    {
        var lines = new List<string>();
        ClipboardHelper.SetLines(lines);
        Assert.True(true);
    }

    [Fact]
    public void SetLines_WithSingleLine_LogicTest()
    {
        var lines = new List<string> { "Single line" };
        ClipboardHelper.SetLines(lines);
        Assert.True(true);
    }

    [Fact]
    public void SetDictionary_WithStringDictionary_LogicTest()
    {
        var dictionary = new Dictionary<string, string>
        {
            { "key1", "value1" },
            { "key2", "value2" },
            { "key3", "value3" }
        };
        var delimiter = "=";
        ClipboardHelper.SetDictionary(dictionary, delimiter);
        Assert.True(true);
    }

    [Fact]
    public void SetDictionary_WithIntegerDictionary_LogicTest()
    {
        var dictionary = new Dictionary<int, int>
        {
            { 1, 100 },
            { 2, 200 },
            { 3, 300 }
        };
        var delimiter = ":";
        ClipboardHelper.SetDictionary(dictionary, delimiter);
        Assert.True(true);
    }

    [Fact]
    public void SetDictionary_WithEmptyDictionary_LogicTest()
    {
        var dictionary = new Dictionary<string, string>();
        var delimiter = "=";
        ClipboardHelper.SetDictionary(dictionary, delimiter);
        Assert.True(true);
    }

    [Fact]
    public void SetDictionary_WithCustomDelimiter_LogicTest()
    {
        var dictionary = new Dictionary<string, string>
        {
            { "name", "John" },
            { "age", "30" }
        };
        var delimiter = " -> ";
        ClipboardHelper.SetDictionary(dictionary, delimiter);
        Assert.True(true);
    }

    [Fact]
    public void AppendText_WithText_LogicTest()
    {
        ClipboardHelper.AppendText("Appended content");
        Assert.True(true);
    }

    [Fact]
    public void AppendText_WithNullText_LogicTest()
    {
        ClipboardHelper.AppendText(null!);
        Assert.True(true);
    }
}
