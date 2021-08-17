using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RichyProject.Data;
using RichyProject.Models;
using RichyProject.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RichyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IYourMessage _yourMessage;
        private readonly DataContext _dataContext;

        public HomeController(ILogger<HomeController> logger, IYourMessage yourMessage, DataContext dataContext)
        {
            _logger = logger;
            _yourMessage = yourMessage;
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Yourmessage()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Yourmessage( YourMessage yourMessage)
        {
            if (ModelState.IsValid)
            {
               await _yourMessage.AddMessage(yourMessage);
                ModelState.Clear();
                TempData["YourMessage"] = "Thank you, we have recieved your message.";
                return RedirectToAction("Index", "Home", "yourmessage");
            }
            else if(!ModelState.IsValid)
            {

                ModelState.AddModelError(string.Empty, "Incorrect Filling!");
                TempData["ErrorMessage"] = "Field not correctly filled!";
                //return RedirectToAction("Index", "Home", "yourmessage");
            }
            return RedirectToAction("Index", "Home", "yourmessage");
        }

       


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
