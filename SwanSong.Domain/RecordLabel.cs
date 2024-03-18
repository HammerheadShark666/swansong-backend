using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwanSong.Domain;

[Table("SWSG_RecordLabel")]
public class RecordLabel : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Name { get; set; }

    public ICollection<Album> Albums { get; set; }

    public RecordLabel()
    { }

    public RecordLabel(int id)
    {
        Id = id;
    }
}
