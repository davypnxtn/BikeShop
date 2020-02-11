using BLL.interfaces;
using DAL;
using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ShoppingItemService:IShoppingItemService
    {
        private readonly IShoppingItemRepository repository;
        private readonly IShoppingBagRepository shoppingBagRepository;
        private readonly IProductRepository productRepository;

        public ShoppingItemService(IShoppingItemRepository _repository,IShoppingBagRepository _shoppingBagRepository, IProductRepository _productRepository)
        {
            repository = _repository;
            shoppingBagRepository = _shoppingBagRepository;
            productRepository = _productRepository;
        }
        public void AddShoppingItem(int shoppingBagId, int productId, int aantal)
        {
            ShoppingBag bag = shoppingBagRepository.FindById(shoppingBagId);
            Product item = productRepository.FindById(productId);
            ShoppingItem shoppingItem = new ShoppingItem()
            {
                ProductID = item.ProductID,
                Product = item,
                Quantity = aantal,
                ShoppingBag = bag,
                ShoppingBagID = bag.ShoppingBagID
            };
            repository.Create(shoppingItem);
        }

        public List<ShoppingItem> FindByShoppingBagID(int id)
        {
            return repository.FindByShoppingBagID(id);
        }

        public void Delete(int id)
        {
            var shoppingItem = repository.FindById(id);
            if (shoppingItem != null)
            {
                repository.Delete(shoppingItem);
            }
        }
    }
}
