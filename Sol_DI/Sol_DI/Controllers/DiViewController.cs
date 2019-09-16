using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_DI.Controllers
{
    public class DiViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}