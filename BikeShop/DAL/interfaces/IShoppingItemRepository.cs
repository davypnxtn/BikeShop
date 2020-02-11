using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.interfaces
{
    public interface IShoppingItemRepository
    {
        ShoppingItem FindById(int id);
        List<ShoppingItem> FindByShoppingBagID(int id);
        void Create(ShoppingItem shoppingItem);
        void Delete(ShoppingItem shoppingItem);
    }
}
