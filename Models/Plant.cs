using System.ComponentModel.DataAnnotations;

namespace PlantsApp.Models
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Colour { get; set; }
        
    }
}
