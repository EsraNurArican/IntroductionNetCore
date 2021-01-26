using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Esra";
            ViewBag.Time = DateTime.Now.Hour;

            // sayfada göstermek için ürünler ekliyoruz
            List<String> products = new List<string>();
            products.Add("Pizza");
            products.Add("Su");
            products.Add("Dondurma");

            ViewBag.Products = products;

            return View();
        }
    }
}
