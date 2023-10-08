using Microsoft.AspNetCore.Mvc;

namespace VendorList.Controllers
{
  public class NewController : Controller
  {
    [HttpGet("/new")]
    public ActionResult Index()
    {
      return View();
    }

  }
}