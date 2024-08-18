namespace SunamoMime.Tests

    public class SunamoMimeHelperTests
    {
        //[Fact]
        public async Task FileTypeTest()
        {
            SunamoMimeHelper.Init();
            var f = @"D:\_Test\sunamo\win\Helpers\MImeHelper\GetMimeFromFile\Real";
            //application/octet-stream>
            Assert.Equal("jpg", SunamoMimeHelper.FileType((await TF.ReadAllBytes(f + AllExtensions.jpg)).ToArray()));
            Assert.Equal("webp", SunamoMimeHelper.FileType((await TF.ReadAllBytes(f + AllExtensions.webp)).ToArray()));
        }
    }
    #endregion
}
