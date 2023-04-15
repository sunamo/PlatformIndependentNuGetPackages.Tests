namespace SunamoTesseract.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            public static void Test()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<string> testFiles = FS.GetFiles(@"D:\Documents\BitBucket\How-to-use-tesseract-ocr-4.0-with-csharp\samples\a\",
                "*", SearchOption.TopDirectoryOnly);
            TesseractArgs a = new TesseractArgs
            { lang = TessearactLang.ces, inputFiles = testFiles, writingOnConsole = true, outputFiles = null };
            ProcessFiles(a);

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
}