using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginWeb.Models;
using LoginWeb.Controllers;

namespace LoginWeb.Controllers
{
    public class Login : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            return Index();
        }
        //[HttpPost]
        public void userClass(string username, string userpassword)
        {

            {
                if (username == "Userugur" && userpassword == "userugur123")
                {

                }
            }
            //return ("id");
        }

    }
}
