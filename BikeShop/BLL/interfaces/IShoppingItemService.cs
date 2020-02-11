using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.interfaces
{
    public interface IShoppingItemService
    {
        void AddShoppingItem(int shoppingBagId, int productId, int aantal);
        List<ShoppingItem> FindByShoppingBagID(int id);
        void Delete(int id);
    }
}
