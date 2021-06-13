using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Person()
        {
            return View();
        }

        public IActionResult Count()
        {
            return View();
        }

        public IActionResult DisplayPerson()
        {
            return View();
        }

        public IActionResult Razor()
        {
            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
       
    }
}
