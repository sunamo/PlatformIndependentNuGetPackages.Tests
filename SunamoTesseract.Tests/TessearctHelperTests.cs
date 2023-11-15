namespace SunamoTesseract.Tests
{
    [TestClass]
    public class TessearctHelperTests
    {
        //[TestMethod]
        public void ProcessFilesTest()
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<string> testFiles = Directory.GetFiles(@"D:\Documents\BitBucket\How-to-use-tesseract-ocr-4.0-with-csharp\samples\a\",
                "*", SearchOption.TopDirectoryOnly).ToList();
            TesseractArgs a = new TesseractArgs
            { lang = TessearactLang.ces, inputFiles = testFiles, writingOnConsole = true, outputFiles = null };
            TessearctHelper.ProcessFiles(a);

            stopwatch.Stop();
            Console.WriteLine("Duration: " + stopwatch.Elapsed);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            string output = string.Empty;
            string tempOutputFile = Path.GetTempPath() + Guid.NewGuid();
            string tempImageFile = Path.GetTempFileName();

        }
    }
}
