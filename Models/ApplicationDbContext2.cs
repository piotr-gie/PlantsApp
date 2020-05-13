using Microsoft.EntityFrameworkCore;

namespace PlantsApp.Models
{
    public class ApplicationDbContext2 : DbContext
    {
        public ApplicationDbContext2(DbContextOptions<ApplicationDbContext2> options) : base(options)
        {

        }

        public DbSet<Seed> Seeds { get; set; }
        public DbSet<Plant> Plant { get; set; }
        public DbSet<Field> Field { get; set; }
    }
}
