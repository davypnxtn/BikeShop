using BLL.interfaces;
using DAL;
using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository _repository)
        {
            repository = _repository;
        }

        public List<Product> GetAllProducts()
        {
            return repository.GetProducts();
        }

        public Product FindById(int id)
        {
            return repository.FindById(id);
        }
    }

}
