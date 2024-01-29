using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Shelter> Shelters { get; set; }
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}