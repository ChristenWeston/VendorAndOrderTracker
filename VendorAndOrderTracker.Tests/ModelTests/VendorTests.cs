using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {

    [TestMethod]
    public void VendorConstructor_CreatesNewVendor()
    {
      Vendor newVendor = new Vendor("Vendor name", "Vendor Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}