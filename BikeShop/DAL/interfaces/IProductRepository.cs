using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product FindById(int id);
    }
}
