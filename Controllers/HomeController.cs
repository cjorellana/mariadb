using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MariaDBTest.Models;
using Microsoft.AspNetCore.Authorization;
using MariaDBTest.Data;

namespace MariaDBTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[Authorize]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            //using (var context = new LibraryContext)
            //{
            //    var books = context.Book;
            //} 

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
