using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerHub.Controllers
{
    public class HighController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
