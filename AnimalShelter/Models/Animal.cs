using System;

namespace AnimalShelter.Models 
{
  public class Animal
  {
    public string Name { get; set; }
    public string Species { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public DateTime CheckIn { get; set; }
    public bool Available { get; set; }
    public int AnimalId { get; set; }
  }
}