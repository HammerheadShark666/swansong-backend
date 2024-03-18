using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwanSong.Domain;

[Table("SWSG_Studio")]
public class Studio : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    [Required]
    public string Name { get; set; }
     
    public Studio()
    { }

    public Studio(int id)
    {
        Id = id;
    }

    public Studio(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
