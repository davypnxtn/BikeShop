using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BikeShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService service;
        private readonly IShoppingBagService shoppingBagService;
        private readonly IShoppingItemService shoppingItemService;

        public ProductController(IProductService _service, IShoppingBagService _shoppingBagService, IShoppingItemService _shoppingItemService)
        {
            service = _service;
            shoppingBagService = _shoppingBagService;
            shoppingItemService = _shoppingItemService;
            
        }
        // Lijst van Producten weergeven
        public IActionResult Index()
        {
            List<Product> products = service.GetAllProducts();
            ViewData["sBagId"] = HomeController.sBagId;
            return View(products);
        }

        //Detail van geselecteerd Product
        public IActionResult Detail(int id)
        {
            var product = service.FindById(id);
            ViewData["sBagId"] = HomeController.sBagId;
            return View(product);
        }

        //Geselecteerd Product met het gewenste aantal toevoegen aan ShoppingBag
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detail(ShoppingBag shoppingBag, Product product, int aantal)
        {
            if (HomeController.sBagId == 0)
            {
                shoppingBagService.Create(shoppingBag);
                HomeController.sBagId = shoppingBag.ShoppingBagID;              
            }           
            shoppingItemService.AddShoppingItem(HomeController.sBagId, product.ProductID, aantal);
            return RedirectToAction("ConfirmProduct", new {id = product.ProductID });
        }

        //Bevestiging van toevoeging Product aan ShoppingBag
        public IActionResult ConfirmProduct(int id)
        {
            var product = service.FindById(id);
            ViewData["sBagId"] = HomeController.sBagId;
            return View(product);
        }
    }
}
