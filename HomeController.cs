using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Byggvarulistan.Models;

namespace Byggvarulistan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buildingproducts()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Buildproject()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Inspiration()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Navigation()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult cart()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Guider()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult GuideExmpl()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult treeguide()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult isoguide()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
