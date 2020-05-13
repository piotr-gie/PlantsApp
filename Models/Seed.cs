using System.ComponentModel.DataAnnotations;

namespace PlantsApp.Models
{
    public class Seed
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
    }
}