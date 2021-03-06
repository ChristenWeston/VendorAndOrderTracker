using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesNewVendor()
    {
      Vendor newVendor = new Vendor("Vendor name", "Vendor Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "description");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "super descriptive";
      Vendor newVendor = new Vendor("vendor name", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Vendor Name";
      Vendor newVendor = new Vendor(name, "description");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      string name1 = "Vendor1";
      string name2 = "Vendor2";
      Vendor newVendor1 = new Vendor(name1, "description1");
      Vendor newVendor2 = new Vendor(name2, "description2");
      List<Vendor> newVendorList = new List<Vendor> {newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendorList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Vendor1";
      string name2 = "Vendor2";
      Vendor newVendor1 = new Vendor(name1, "description1");
      Vendor newVendor2 = new Vendor(name2, "description2");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
  }
}