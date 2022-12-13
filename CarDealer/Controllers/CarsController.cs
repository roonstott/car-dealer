using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;
using System.Collections.Generic;

namespace CarDealer.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allItems = Car.GetAll();
      return View(allItems);
    }

    [HttpPost("/cars/new")]
    public ActionResult Create(string description, string makeModel, int miles, int price, string year)
    {
      Car myCar = new Car(description, makeModel, miles, price, year);
      return RedirectToAction("Index");
    }

  }
}
