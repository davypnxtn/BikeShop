using Model;
using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.interfaces
{
    public interface IShoppingBagService
    {
        ShoppingBag FindById(int id);
        void Create(ShoppingBag shoppingBag);
        ShoppingBagDetailViewModel CreateShoppingBagDetailViewModel(int id);
    }
}
