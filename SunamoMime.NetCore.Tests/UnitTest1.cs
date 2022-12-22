using Microsoft.VisualStudio.TestTools.UnitTesting;
using SunamoExceptions;

namespace SunamoMime.NetCore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        #region For easy copy
        public class SunamoMimeHelperTests
        {
            [TestMethod]
            public void FileType_NetCore_Test()
            {
                SunamoMimeHelper.Init();
                var f = @"D:\_Test\sunamo\win\Helpers\MImeHelper\GetMimeFromFile\Real";
                //application/octet-stream>
                Assert.AreEqual("jpg", SunamoMimeHelper.FileType(TF.ReadAllBytes(f + AllExtensions.jpg).ToArray()));
                Assert.AreEqual("webp", SunamoMimeHelper.FileType(TF.ReadAllBytes(f + AllExtensions.webp).ToArray()));
            }
        }
        #endregion
    }
}
