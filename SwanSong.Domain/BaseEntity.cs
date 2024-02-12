using System;

namespace SwanSong.Domain;

public class BaseEntity
{        
    public DateTime AddedDate { get; set; }
    
    public DateTime ModifiedDate { get; set; }

    public BaseEntity()
    {
        AddedDate = DateTime.Now;
        ModifiedDate = DateTime.Now;
    }

    public static string DefaultArtistPhotoFileName = "default-artist-image.jpg";
    public static string DefaultAlbumPhotoFileName = "default-album-image.jpg";
    public static string DefaultMemberPhotoFileName = "default-member-image.jpg";
}
