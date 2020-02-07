using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Week3.Models;

namespace Week3.Controllers
{
    public class ConnectusController : Controller
    {
        [HttpGet]
        public IActionResult Connectus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Connectus(Connectus contact)
        {
            return View(contact);
        }
    }
}