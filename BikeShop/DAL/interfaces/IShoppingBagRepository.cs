using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.interfaces
{
    public interface IShoppingBagRepository
    {
        ShoppingBag FindById(int id);
        void Create(ShoppingBag shoppingBag);
    }
}
