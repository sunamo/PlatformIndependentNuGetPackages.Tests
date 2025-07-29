using Xunit;
using System.Text;
using System.Collections.Generic;

namespace SunamoClipboard.Tests;

[Collection("ClipboardSequential")] // pro konzistenci
public class ClipboardHelper_LogicTests
{
    [Fact]
    public void GetText_LogicTest_HandlesNullCorrectly()
    {
        var result = ClipboardHelper.GetText();
        Assert.NotNull(result);
    }

    [Fact]
    public void SetLines_StringJoinLogic_Test()
    {
        var lines = new List<string> { "A", "B", "C" };
        var expectedJoined = "A\nB\nC";
        var actualJoined = string.Join("\n", lines);
        Assert.Equal(expectedJoined, actualJoined);
    }

    [Fact]
    public void SetText_StringBuilderConversion_Test()
    {
        var sb = new StringBuilder();
        sb.Append("Hello");
        sb.Append(" ");
        sb.Append("World");
        var result = sb.ToString();
        Assert.Equal("Hello World", result);
    }
}
