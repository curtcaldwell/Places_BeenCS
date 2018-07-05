using Microsoft.AspNetCore.Mvc;
using Place.Models;

namespace Place.Controllers
{
  public class LocationController : Controller
  {
    [HttpGet("/city")]
    public ActionResult Cities()
    {
      return View(PlaceBeen.GetAll());
    }
    [HttpGet("/city/add")]
    public ActionResult Form()
    {
      return View();
    }
    [HttpPost("/city")]
    public ActionResult Create(string city, int year)
    {
      PlaceBeen newPlaceBeen = new PlaceBeen(city, year);
      newPlaceBeen.Save();
      return View("Cities", PlaceBeen.GetAll());
    }
  }
}
