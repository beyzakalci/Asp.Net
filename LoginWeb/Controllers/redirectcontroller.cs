using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWeb.Controllers
{
    public class redirectcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
   
}
