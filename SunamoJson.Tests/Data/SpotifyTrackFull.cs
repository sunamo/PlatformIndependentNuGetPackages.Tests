using System.Runtime.Serialization;

public class SpotifyTrackFull : SpotifyTrackSimplified
{
    [DataMember(Name = "album")]
    public SpotifyAlbumSimplified album { get; set; }
}
