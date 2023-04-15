using System.Collections.Generic;
using System.Runtime.Serialization;

public class SpotifyImage
{
    
    [DataMember(Name = "width")]
    public int width { get; set; }
    [DataMember(Name = "height")]
    public int height { get; set; }
    [DataMember(Name = "url")]
    public string url { get; set; }
}
