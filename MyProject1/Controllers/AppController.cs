using Microsoft.AspNetCore.Mvc;
using MyProject1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject1.Controllers
{
    public class AppController: Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            //throw new InvalidOperationException("Bad things happen");

            ViewBag.Title = "Contact Us";
            return View();
        }
        
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModels model)
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
