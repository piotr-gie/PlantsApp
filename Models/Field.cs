using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
