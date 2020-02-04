using System;
using Microsoft.AspNetCore.Mvc;
using Charts.Models;

namespace Charts.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
