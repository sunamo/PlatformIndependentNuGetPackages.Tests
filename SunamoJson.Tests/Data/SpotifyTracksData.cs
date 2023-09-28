public class SpotifyTracksData
{
    [DataMember(Name = "items")]
    public List<SpotifyTrackFull> items = new List<SpotifyTrackFull>();
}
