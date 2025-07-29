namespace SunamoCl.Tests;

using System;




public class CLTests
{
    public void LoadFromClipboardOrConsoleTest()
    {
        // Safe temp file creation
        var tempDir = Path.GetTempPath();
        var tempFileName = Path.GetRandomFileName() + ".tmp";
        var tempFilePath = Path.Combine(tempDir, tempFileName);

        // Ensure temp directory exists (it should, but being safe)
        Directory.CreateDirectory(tempDir);

        Clipbo
        //ClipboardHelper.SetFileToClipboard(tempFilePath);

        var clipboardText = "text";
        var loaded = CL.LoadFromClipboardOrConsole(clipboardText);
        CL.Success("Loaded text: " + loaded);
    }

    public void GetFileFromClipboardTest()
    {
        // Create a temporary file for testing
        var tempDir = Path.GetTempPath();
        var tempFileName = Path.GetRandomFileName() + ".tmp";
        var tempFilePath = Path.Combine(tempDir, tempFileName);

        // Create the temp file
        File.WriteAllText(tempFilePath, "Test content");

        try
        {
            // Set file to clipboard
            ClipboardHelper.SetFileToClipboard(tempFilePath);

            // Get files from clipboard
            var filesFromClipboard = ClipboardHelper.GetFileFromClipboard();

            if (filesFromClipboard.Count > 0)
            {
                CL.Success($"Retrieved {filesFromClipboard.Count} file(s) from clipboard:");
                foreach (var file in filesFromClipboard)
                {
                    CL.Information($"  - {file}");
                }
            }
            else
            {
                CL.Warning("No files found in clipboard");
            }
        }
        finally
        {
            // Clean up temp file
            if (File.Exists(tempFilePath))
            {
                File.Delete(tempFilePath);
            }
        }
    }
}


