using Microsoft.AspNetCore.Mvc;
using RichyProject.Data;
using RichyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RichyProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _dataContext;
        public AccountController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
           
            
                var returnList = _dataContext.yourMessages.ToList();
                //var wsd=   _yourMessage.ListMesaages();
                return View(returnList);
            
        }

        public async Task<IActionResult> Details(int id)
        {
            var returnDetail = _dataContext.yourMessages.FirstOrDefault(s => s.Id == id);
            return View(returnDetail);
        }
    }
}
