using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwanSong.Domain;

[Table("SWSG_Song")]
public class Song : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Column(TypeName = "nvarchar(150)")]
    [Required]
    public string Title { get; set; } 

    public string Length { get; set; }      

    public List<SongWriter> SongWriters { get; set; }         

    public Song()
    {
        SongWriters = new List<SongWriter>(); 
    }
}
