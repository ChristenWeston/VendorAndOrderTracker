using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {

    public string Description { get; set; }
    public string Title { get; set; }
    public double Price {get; set; }
    public string Date {get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string description, string title, string price, string date)
    {
      double priceToInt;
      Description = description;
      Title = title;
      Double.TryParse(price, out priceToInt);
      Price = priceToInt;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int orderId)
    {
      return _instances[orderId-1];
    }
  }
}