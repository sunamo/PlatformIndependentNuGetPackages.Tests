using TextCopy;
using System;

namespace SunamoClipboard.Tests;

public static class ClipboardTestEnv
{
    public static readonly bool ClipboardSupported = DetectClipboard();

    private static bool DetectClipboard()
    {
        try
        {
            var testString = "clipboard_test_" + Guid.NewGuid();
            ClipboardService.SetText(testString);
            var result = ClipboardService.GetText();
            return !string.IsNullOrEmpty(result) && result == testString;
        }
        catch
        {
            return false;
        }
    }
}
