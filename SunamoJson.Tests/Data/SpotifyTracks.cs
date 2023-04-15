using System.Runtime.Serialization;

public class SpotifyTracks
{
    [DataMember(Name = "tracks")]
    public SpotifyTracksData tracks { get; set; }
}
