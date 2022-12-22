using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

public class Utf8JsonTests
{
    static JavascriptSerialization js = null;

    void Init()
    {
        js = new JavascriptSerialization(SerializationLibrary.Utf8Json);
    }

    [Fact]
    public void Utf8JsonTest()
    {
        Init();

        /*
        Deserialize without define type is not possible in Utf8Json
        Fortunately there are many tool to help with it:
        https://json2csharp.com/
        https://app.quicktype.io/
        https://www.google.com/search?q=c%23+type+from+json etc

                    */
        var input = "{\"price\":\"450000\", \"position\":\"0\", \"id\": \"18787720\", \"stitky\":\"servisn� kn�ka, bluetooth, satelitn� navigace\"}";
        var o = js.Deserialize<Root>(input);
    }

    [Fact]
    public void SpotifyTracksTest()
    {
        var s = TF.ReadAllText(@"D:\_Test\sunamoWithoutDep\SunamoJson\SpotifyTracks.json");

        Init();

        var v = js.Deserialize<SpotifyTracks>(s);

    }
}
