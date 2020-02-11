using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.interfaces;

namespace DAL
{
    public class ProductRepository:IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product FindById(int id)
        {
            //Vragen wat het verschil is tussen onderstaande, performantie?
            //return context.Products.Find(id);
            return _context.Products.Where(p => p.ProductID == id).Single();
        }
    }
}
