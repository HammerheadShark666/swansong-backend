using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwanSong.Domain;

[Table("SWSG_Country")]
public class Country : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string Name { get; set; }

    [ForeignKey("CountryId")]
    public ICollection<Artist> Artists{ get; set; }

    [ForeignKey("CountryId")]
    public ICollection<BirthPlace> BirthPlaces { get; set; }

    public Country()
    { }

    public Country(byte id)
    {
        Id = id;
    }

    public Country(byte id, string name)
    {
        Id = id;
        Name = name;
    }
}
