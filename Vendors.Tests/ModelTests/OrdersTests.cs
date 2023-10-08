using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorList.Models;
using System.Collections.Generic;

namespace Vendors.Tests
{
  [TestClass]
  public class OrdersTests
  {

    [TestMethod]
    public void AddOrder_AddsNewOrderToVendor()
    {
      //Arrange
      Vendor vendor = new Vendor { Name = "slurb", Desc = "likes blurb" };
      Order order1 = new Order { OrderDetails = "50 blurbs" };
      Order order2 = new Order { OrderDetails = "50 gnurbs" };
      //Act
      vendor.VendorOrder.Add(order1);
      vendor.VendorOrder.Add(order2);
      //Assert
      Assert.AreEqual(2, vendor.VendorOrder.Count);
      CollectionAssert.Contains(vendor.VendorOrder, order1);
      CollectionAssert.Contains(vendor.VendorOrder, order2);
    }
  }
}