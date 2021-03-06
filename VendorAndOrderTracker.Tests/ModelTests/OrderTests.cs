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
      Order newOrder = new Order("Order1", "OrderTitle", "1.99", "OrderDate");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string description = "100 cases of Olives";
      Order newOrder = new Order(description, "orderTitle", "1.99", "orderDate");
      
      string result = newOrder.Description;
      
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string title = "New Order from Luis";
      Order newOrder = new Order("description", title, "1.99", "orderDate");
      
      string result = newOrder.Title;
      
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      string date = "1/1/2022";
      Order newOrder = new Order("description", "title", "1.99", date);
      
      string result = newOrder.Date;
      
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Double()
    {
      double price = 1.99;
      string priceForOrder = "1.99";
      Order newOrder = new Order("Order1", "OrderTitle", priceForOrder, "OrderDate");

      Assert.AreEqual(price, newOrder.Price, 0.00000001);
    }

    [TestMethod]
    public void SetOrderDescription_SetDescription_String()
    {
      string description = "10 cases of olives";
      Order newOrder = new Order(description, "orderTitle", "1.99", "orderDate");

      string updatedDescription = "20 cases of olives";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetALL_ReturnsOrders_OrderList()
    {
      string description01 = "300 crates of apples";
      string description02 = "200 lbs of flour";
      Order newOrder1 = new Order(description01, "orderTitle", "1.99", "orderDate");
      Order newOrder2 = new Order(description02, "orderTitle2", "2.99", "orderDate2");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string description = "1 lb of salt";
      Order newOrder = new Order(description, "orderTitle", "1.99", "orderDate");

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string description01 = "50 lbs whole wheat flour";
      string description02 = "10 lbs of brown sugar";
      Order newOrder1 = new Order(description01, "orderTitle", "1.99", "orderDate");
      Order newOrder2 = new Order(description02, "orderTitle2", "2.99", "orderDate2");

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}