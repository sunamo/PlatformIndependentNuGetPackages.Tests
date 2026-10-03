public class OCREngine
{
    #region Methods

    static void Main()
    {
        

        //GetOCRText(@"D:\vs\NotMine.Tests\Tesseract.Tests\tessdata", new Bitmap(@"D:\vs\NotMine.Tests\Tesseract.Tests\p.tif"));
    }

    public static string GetOCRText(string engpath, Image imgdata)
    {
        string rst = "";

        try
        {
            var cmdArgs = Environment.GetCommandLineArgs();
            Directory.SetCurrentDirectory(System.IO.Path.GetDirectoryName(cmdArgs[0]));
            using (var engine = new TesseractEngine(engpath, "eng", EngineMode.Default))
            {
                using (Bitmap image = new Bitmap(imgdata))
                {
                    using (var pix = Pix.LoadFromMemory(ToPngBytes(image)))
                    {
                        using (var page = engine.Process(pix))
                        {
                            rst = page.GetText().Trim();
                        }
                    }
                }
            }
        }
        catch (System.Exception ex)
        {

            //ScratchModel.WriteLogFile("----Error----", "------ GetOCRText1 -------", "");

        }

        return rst;
    }

    private static byte[] ToPngBytes(Bitmap bitmap)
    {
        using var ms = new MemoryStream();
        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        return ms.ToArray();
    }

    #endregion Methods
}
