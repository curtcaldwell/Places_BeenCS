using Microsoft.AspNetCore.Mvc;
using Place.Models;

namespace Place.Controllers
{
  public class HomeController : Controller
{

  [HttpGet("/")]
  public ActionResult Index()
  {
    return View();
  }
}
}
