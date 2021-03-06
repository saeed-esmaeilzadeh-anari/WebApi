using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
  public class Ingredient
  {
    [Key]
    public int Id { get; set; }
    [Required]

    [Column(TypeName = "varchar(100)")]
    public string Name { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Description { get; set; }

    [Column(TypeName = "varchar(1000)")]
    public string ImgPath { get; set; }
  }
}
