using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwanSong.Domain;

[Table("SWSG_Album")]
public class Album : BaseEntity
{
    private int? labelId;
    private int? studioId;

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Column(TypeName = "nvarchar(120)")]
    [Required]         
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string Photo { get; set; }

    [Column(TypeName = "datetime2(7)")]
    public DateTime? RecordedDate { get; set; }

    [Column(TypeName = "datetime2(7)")]     
    public DateTime? ReleaseDate { get; set; }

    [Column(TypeName = "int")]
    public int? LabelId
    {
        get
        {
            if (this.labelId == 0)
            {
                return null;
            }
            return this.labelId;
        }
        set { this.labelId = value; }
    }

    public RecordLabel Label { get; set; }

    [Column(TypeName = "int")]
    public int? StudioId
    {
        get
        {
            if (this.studioId == 0)
            {
                return null;
            }
            return this.studioId;
        }
        set { this.studioId = value; }
    }

    public Studio Studio { get; set; }

    [Column(TypeName = "bigint")] 
    public long ArtistId { get; set; }

    public virtual Artist Artist { get; set;}       
     
    [Column(TypeName = "nvarchar(250)")]
    public string Producers { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string Arrangers { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string Engineers { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string Artwork { get; set; }

    public ICollection<AlbumSong> AlbumSongs { get; set; }

    public Album()
    {
        AlbumSongs = new HashSet<AlbumSong>();
        Photo = DefaultAlbumPhotoFileName;
        StudioId = null;
        labelId = null;
    }     
}
