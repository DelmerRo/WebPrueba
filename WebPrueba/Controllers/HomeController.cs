using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Data;
using WebPrueba.Models;

namespace WebPrueba.Controllers
{
    public class HomeController : Controller
    {
        public ForoContext Bd { get; set; }

        public HomeController(ForoContext algoDeData)
        {
            Bd = algoDeData;
        }

        public IActionResult Index()
        {
          

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
    