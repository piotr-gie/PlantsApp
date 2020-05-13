using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlantsApp.Models
{
    public class Field
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Plant")]
        [Required]
        public int PlantId { get; set; }
    }
}
