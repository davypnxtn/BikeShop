using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BikeShop.Controllers
{
    public class ShoppingItemController : Controller
    {
        private readonly IShoppingItemService service;

        public ShoppingItemController(IShoppingItemService _service)
        {
            service = _service;
        }

        //ShoppingItem verwijderen uit ShoppingBag
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return RedirectToAction("Detail", "ShoppingBag", new { id = HomeController.sBagId});
        }
    }
}
