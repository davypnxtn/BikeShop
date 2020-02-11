using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.ViewModel;


namespace BikeShop.Controllers
{

 
    public class ShoppingBagController : Controller
    {
        private readonly IShoppingBagService service;

        public ShoppingBagController(IShoppingBagService _service)
        {
            service = _service;
        }

        //Details van de ShoppingBag weergeven
        public IActionResult Detail(int id)
        {
            if (id != 0)
            {
                var shoppingBagDetailVM = service.CreateShoppingBagDetailViewModel(id);
                ViewData["sBagId"] = HomeController.sBagId;
                return View(shoppingBagDetailVM);
            }
            ViewData["sBagId"] = HomeController.sBagId;
            return RedirectToAction("Emptypage");
        }

        //View wanneer ShoppingBag nog niet aangemaakt is
        public IActionResult Emptypage()
        {
            ViewData["sBagId"] = HomeController.sBagId;
            return View();
        }

        //Bestelling bevestigen
        public IActionResult ConfirmOrder()
        {
            HomeController.sBagId = 0;
            ViewData["sBagId"] = HomeController.sBagId;
            return View();
        }
    }
}
