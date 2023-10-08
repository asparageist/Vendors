using Microsoft.AspNetCore.Mvc;
using VendorList.Models;

namespace VendorList.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("Vendor/{vendorId}/AddOrder")]
    public ActionResult Orders(int vendorId)
    {
      Vendor vendor = ThoseWhoVend.GetVendorById(vendorId);
      if (vendor == null)
        return NotFound();

      return View("~/Views/New/Orders.cshtml", vendor);
    }

    [HttpPost("Vendor/{vendorId}/AddOrder")]
    public ActionResult AddOrder(int vendorId, string itemName)
    {
      Order newOrder = new Order
      {
        ItemName = itemName
      };
      ThoseWhoVend.AddOrder(vendorId, newOrder);
      return RedirectToAction("Orders", "Vendors", new { id = vendorId });
    }

  }
}