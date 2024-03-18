using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwanSong.Domain;

[Table("SWSG_AlbumSong")]
public class AlbumSong : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public long AlbumId { get; set; }

    public virtual Album Album { get; set; }

    public long SongId { get; set; }

    public virtual Song Song { get; set; }
     
    public int? Order { get; set; }
     
    public int? Side { get; set; }
}
