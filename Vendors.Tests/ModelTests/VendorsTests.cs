using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorList.Models;
using System.Collections.Generic;

namespace Vendors.Tests
{
  [TestClass]
  public class VendorsTests
  {

    [TestMethod]
    public void AddVendor_AddsNewVendor()
    {

      //Arrange
      Vendor vendor = new Vendor
      {
        Name = "noop",
        Desc = "likes boop",
        VendorOrder = new List<Order>
         {
          new Order { OrderDetails="50 scoops"},
          new Order {OrderDetails="50 boops" }
         }
      };

      //Act
      ThoseWhoVend.AddVendor(vendor);

      //Assert
      CollectionAssert.Contains(ThoseWhoVend.GetVendors(), vendor);
    }

    [TestMethod]
    public void AddVendor_GivesEachVendorUniqueIDNumber()
    {
      //Arrange
      Vendor vendor1 = new Vendor { Name = "bob", Desc = "likes blob" };
      Vendor vendor2 = new Vendor { Name = "andy", Desc = "likes candy" };
      //Act
      ThoseWhoVend.AddVendor(vendor1);
      ThoseWhoVend.AddVendor(vendor2);
      //Assert
      Assert.AreEqual(1, vendor1.ID);
      Assert.AreEqual(2, vendor2.ID);
    }
  }
}