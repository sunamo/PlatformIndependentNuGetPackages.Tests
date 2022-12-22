using System.Collections.Generic;
using System.Runtime.Serialization;

public class SpotifyTrackSimplified
{
    [DataMember(Name = "artists")]
    public List<SpotifyArtistSimplified> artists { get; set; } 
    [DataMember(Name = "name")]
    public string name { get; set; }
}
