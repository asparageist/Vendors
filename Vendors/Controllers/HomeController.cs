using Microsoft.AspNetCore.Mvc;

namespace VendorList.Controllers
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