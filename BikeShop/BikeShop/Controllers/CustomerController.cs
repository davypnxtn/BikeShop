using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BikeShop.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService service;

        public CustomerController(ICustomerService _service)
        {
            service = _service;
        }

        //Login
        public IActionResult Login(int id)
        {
            var customer = service.FindById(id);
            ViewData["sBagId"] = HomeController.sBagId;
            return View(customer);
        }
    }
}
