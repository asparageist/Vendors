using System.Collections.Generic;
using System;
using VendorList.Controllers;

namespace VendorList.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Desc { get; set; }
    public int ID { get; set; }
    public List<Order> VendorOrder { get; set; } = new List<Order>();

  }
  public class ThoseWhoVend
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    private static int _vendorID = 0;
    public static void AddVendor(Vendor vendor)
    {
      _instances.Add(vendor);
      vendor.ID = _vendorID++;
    }

    public static void AddOrder(int vendorID, Order order)
    {
      Vendor vendor = _instances.Find(v => v.ID == vendorID);
      if (vendor != null)
      {
        vendor.VendorOrder.Add(order);
      }
    }
    public static List<Vendor> GetVendors()
    {
      return _instances;
    }

  }
}