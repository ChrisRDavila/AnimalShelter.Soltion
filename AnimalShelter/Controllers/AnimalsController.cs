using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;
    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Animal> model = _db.Animals
      .OrderBy(animal => animal.Name)//can still treat it like sql data
      .ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }
    //----------------
    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    //-----------------
    public ActionResult Details(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      return View(thisAnimal);
    }

    public ActionResult Date()
    {
      List<Animal> model = _db.Animals
      .OrderBy(animal => animal.CheckIn)
      .ToList();
      return View(model);
    }

    public ActionResult Dogs()
    {
      List<Animal> model = _db.Animals
      .Where(animal => animal.Species == "Dog")
      .ToList();
      return View(model);
    } 

    public ActionResult Edit(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      return View(thisAnimal);
    }

    [HttpPost]
    public ActionResult Edit(Animal animal)
    {
      _db.Animals.Update(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}