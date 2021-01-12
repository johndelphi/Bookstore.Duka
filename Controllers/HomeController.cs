using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
  public class HomeController : Controller
  {
    public  ViewResult Index()
    {
            ViewBag.name = "john";
            dynamic data = new ExpandoObject();
            data.id = 1;
            data.Name = "Muema";
     
      return View();
    }
    public ViewResult AboutUs()
    {
      return View();
    }
    public ViewResult ContactUs()
    {
      return View();
        }
  }
}