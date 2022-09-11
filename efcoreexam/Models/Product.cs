using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efcoreexam.Models
{
    public class Product
    {
        [Required]
        [Column("Id")]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
