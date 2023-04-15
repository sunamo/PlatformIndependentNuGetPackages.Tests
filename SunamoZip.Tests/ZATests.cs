using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sunamo.Essential;

namespace SunamoZip.Tests
{
    [TestClass]
    public class ZATests
    {

        [TestMethod]
        public void CreateArchiveTest()
        {
            var folder = @"D:\_Test\sunamoWithoutDepSunamoZip\SunamoZip\ToZip\";

            var z = ZA.zip;
            var files = FS.GetFiles(folder, "*.txt", SearchOption.AllDirectories);
            z.CreateArchive(folder, files, @"D:\_Test\sunamoWithoutDepSunamoZip\1.zip");
        }
    }
}
