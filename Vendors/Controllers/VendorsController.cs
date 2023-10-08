using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorList.Models;

namespace VendorList.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> vendors = ThoseWhoVend.GetVendors();
      return View(vendors);
    }

    [HttpGet("/vendor/orders/{id}")]
    public ActionResult Orders(int id)
    {
      Vendor vendor = ThoseWhoVend.GetVendorById(id);

      if (vendor == null)
        return NotFound();
      return View(vendor);
    }

    [HttpPost("/vendors/add")]
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

    [HttpGet("/new/vendor")]
    public ActionResult AddVendors()
    {
      return View("Views/New/Vendors.cshtml");
    }


  }
}