using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
       Vendor vendor = Vendor.Find(vendorId);
       return View(vendor);
    }
  }
}