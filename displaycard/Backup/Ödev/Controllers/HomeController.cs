using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Ödev.Models;

namespace Ödev.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(String order)
        {

            GPUClass gpu1 = new GPUClass(id: 1, name: "MSI GeForce GT 710", price: 407.70);
            GPUClass gpu2 = new GPUClass(id: 2, name: "MSI GeForce GTX 1050 Ti", price: 1379.90);
            GPUClass gpu3 = new GPUClass(id: 3, name: "MSI GeForce GTX 1650", price: 1684.16);
            GPUClass gpu4 = new GPUClass(id: 4, name: "ASUS ROG STRIX Radeon", price: 1918.38);
            GPUClass gpu5 = new GPUClass(id: 5, name: "MSI Radeon RX 5500 ", price: 2336.34);
            GPUClass gpu6 = new GPUClass(id: 6, name: "GIGABYTE GeForce GTX 1660 ", price: 2677.13);
            GPUClass gpu7 = new GPUClass(id: 7, name: "MSI GeForce GTX 1660", price: 2858.93);
            GPUClass gpu8 = new GPUClass(id: 8, name: "MSI GeForce GT 710", price: 407);

            List<GPUClass> gpuList = new List<GPUClass>();

            //ADD CLASS TO LIST
            gpuList.Add(gpu4);
            gpuList.Add(gpu1);
            gpuList.Add(gpu2);
            gpuList.Add(gpu8);
            gpuList.Add(gpu3);
            gpuList.Add(gpu6);
            gpuList.Add(gpu7);
            gpuList.Add(gpu5);

            if (order == "asc")
            {
                gpuList.Sort((x, y) => x.price.CompareTo(y.price));
            }
            else if (order == "desc")
            {
                gpuList.Sort((x, y) => y.price.CompareTo(x.price));
            }


            ViewData["gpuList"] = gpuList;

            return View();
        }
    }
}
