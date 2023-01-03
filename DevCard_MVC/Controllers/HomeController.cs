using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<Service> _services = new()
        { new Service(id:1 , name: "نقره ای"),
            new Service(id:2 , name: "طلایی"),
            new Service(id:3 , name: "پلاتین"),
            new Service(id:4 , name: "الماس") };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "Invalid Input";
                return View(model);
            }

            ModelState.Clear();
            model = new Contact { Services = new SelectList(_services,"Id", "Name") };
            ViewBag.success = "Data saved successfully";
            return View(model);

        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    var email = form["email"];
        //    var message = form["message"];
        //    var service = form["service"];
        //    return Json(Ok());
        //}


        //[HttpPost]
        //public JsonResult Contact(Contact form)
        //{
        //    Console.WriteLine(form.ToString());
        //    return Json(Ok());
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
