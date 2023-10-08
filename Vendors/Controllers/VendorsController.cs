using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorList.Models;

namespace VendorList.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendors = ThoseWhoVend.GetVendors();
      return View(vendors);
    }


    [HttpPost]
    public ActionResult Add(string Name, string Desc, int ID)
    {
      Vendor newVendor = new Vendor
      {
        Name = Name,
        Desc = Desc,
        ID = ID
      };

      ThoseWhoVend.AddVendor(newVendor);

      return RedirectToAction("Index");
    }


  }
}