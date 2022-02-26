using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreateInstancesOfOrder_Order()
    {
      Order newOrder = new Order("Order1");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string description = "100 cases of Olives";
      Order newOrder = new Order(description);
      
      string result = newOrder.Description;
      
      Assert.AreEqual(description, result);
    }
  }
}