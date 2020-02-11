using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product FindById(int id);
    }
}
