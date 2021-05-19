using LoginWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            userClass user = new userClass(username: "Userugur", userpassword: "userugur123");
            adminClass admin = new adminClass(adminname: "Adminugur", adminpassword: "adminugur123");
            systemClass system = new systemClass(systemname: "Systemugur", systempassword: "systemugur123");

            return View();
        }
    }
}

    


//    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     IActionResult Error()
//    {
//        return (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//    }
//}}