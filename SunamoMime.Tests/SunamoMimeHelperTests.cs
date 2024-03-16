using SunamoExceptions.InSunamoIsDerivedFrom;
using SunamoFileExtensions;

namespace SunamoMime.Tests
{
    #region For easy copy
    public class SunamoMimeHelperTests
    {
        //[Fact]
        public async Task FileTypeTest()
        {
            SunamoMimeHelper.Init();
            var f = @"D:\_Test\sunamo\win\Helpers\MImeHelper\GetMimeFromFile\Real";
            //application/octet-stream>
            Assert.Equal("jpg", SunamoMimeHelper.FileType((await TFSE.ReadAllBytes(f + AllExtensions.jpg)).ToArray()));
            Assert.Equal("webp", SunamoMimeHelper.FileType((await TFSE.ReadAllBytes(f + AllExtensions.webp)).ToArray()));
        }
    }
    #endregion
}
