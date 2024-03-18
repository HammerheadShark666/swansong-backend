using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwanSong.Domain;

[Table("SWSG_BirthPlace")]
public class BirthPlace : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Name { get; set; }
                    
    public int? CountryId { get; set; }
    
    public Country Country { get; set; }
     
    public BirthPlace()
    { }

    public BirthPlace(int id)
    {
        Id = id;
    }
}
