using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //var obj = new { Id = 1, name = "naman" };
            //return View("~/TempView/MyTempView.cshtml");
            //return View("../../TempView/MyTempView");
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
