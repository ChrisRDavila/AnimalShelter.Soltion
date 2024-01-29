using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Shelter
  {
    public int ShelterId { get; set; }
    public string Business { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public List<Animal> Animals { get; set; }

  }
}