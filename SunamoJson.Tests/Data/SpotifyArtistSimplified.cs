using System;
using System.Runtime.Serialization;

public class SpotifyArtistSimplified : IArtist
{
    [DataMember(Name = "name")]
    public string name { get; set; }

    [DataMember(Name = "id")]
    public string id
    {
        get;
        set;
    }
}
