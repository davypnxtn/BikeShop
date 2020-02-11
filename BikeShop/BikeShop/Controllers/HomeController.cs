using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BikeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculatorService service;

        public static int sBagId = 0;
        public HomeController(ICalculatorService _service)
        {
            service = _service;
        }

        //Op de startpagina wordt er een afbeelding getoond.
        //Aan de hand van een random getal wordt er een keuze gemaakt tussen 4 verschillende afbeeldingen
        public IActionResult Index()
        {           
            int rnd = service.Random();
            string src = "";
            switch (rnd)
            {
                case 1:
                    src = "/images/landing/bikes_category_CITY.jpg";
                    break;
                case 2:
                    src = "/images/landing/bikes_category_e-bike.jpg";
                    break;
                case 3:
                    src = "/images/landing/bikes_category_MTB.jpg";
                    break;
                case 4:
                    src = "/images/landing/bikes_category_RACE.jpg";
                    break;
            }
            ViewData["Source"] = src;
            return View();
        }

    }
}