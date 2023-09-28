public class SpotifyAlbumSimplified : IAlbum
{
    [DataMember(Name = "name")]
    public string name
    {
        get;
        set;
    }
    [DataMember(Name ="id")]
    public string id
    {
        get;
        set;
    }
    [DataMember(Name ="album_type")]
    public string album_type
    {
        get;
        set;
    }
    [DataMember(Name = "images")]
    public List<SpotifyImage> images { get; set; }
}
