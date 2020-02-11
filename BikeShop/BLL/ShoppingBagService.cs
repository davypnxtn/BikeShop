using BLL.interfaces;
using DAL;
using DAL.interfaces;
using Model;
using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ShoppingBagService:IShoppingBagService
    {
        private readonly IShoppingBagRepository repository;
        private readonly IShoppingItemRepository shoppingItemRepository;
        private readonly ICalculatorService calculatorService;

        public ShoppingBagService(IShoppingBagRepository _repository, IShoppingItemRepository _shoppingItemRepository, ICalculatorService _calculatorService)
        {
            repository = _repository;
            shoppingItemRepository = _shoppingItemRepository;
            calculatorService = _calculatorService;
        }

        public ShoppingBag FindById(int id)
        {
            return repository.FindById(id);
        }

        public void Create(ShoppingBag shoppingBag)
        {
            shoppingBag.Date = DateTime.Now;
            shoppingBag.CustomerID = 1;
            repository.Create(shoppingBag);
        }

        public ShoppingBagDetailViewModel CreateShoppingBagDetailViewModel(int id)
        {
            var shoppingBagDetailVM = new ShoppingBagDetailViewModel();
            shoppingBagDetailVM.ShoppingBag = FindById(id);
            shoppingBagDetailVM.ShoppingItems = shoppingItemRepository.FindByShoppingBagID(id);
            //Indien shoppingItemService.FindByShoppingBagID(id) niet met eager loading (.Include) uitgevoerd wordt
            //vul ik met onderstaande lijst de shoppingItems met de juiste producten op.
            //var products = new List<Product>();
            foreach (var item in shoppingBagDetailVM.ShoppingItems)
            {
                //Voor ieder shoppingItem het juiste product toevoegen
                //var product = productService.FindById(item.ProductID);
                //products.Add(product);

                shoppingBagDetailVM.TotaalAantal += item.Quantity;
                shoppingBagDetailVM.SubTotaal += item.SubTotaal;
            }
            shoppingBagDetailVM.Totaal = calculatorService.BerekenTotaal(shoppingBagDetailVM.SubTotaal, shoppingBagDetailVM.TotaalAantal);
            shoppingBagDetailVM.Korting = calculatorService.BerekenKorting(shoppingBagDetailVM.SubTotaal, shoppingBagDetailVM.Totaal);
            return shoppingBagDetailVM;
        }
    }
}
