using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace VendorList.Models
{
  public class Order
  {
    public string OrderDetails { get; set; }
    public int OrderID { get; set; }
    public string ItemName { get; set; }

  }
}