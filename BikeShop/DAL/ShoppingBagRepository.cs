using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Model;
using DAL.interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    
    public class ShoppingBagRepository:IShoppingBagRepository
    {
        private readonly DataContext _context;
        public ShoppingBagRepository(DataContext context)
        {
            _context = context;
        }
        public ShoppingBag FindById(int id)
        {
            return _context.ShoppingBags.Where(s => s.ShoppingBagID == id).Single();              
        }

        public void Create(ShoppingBag shoppingBag)
        {
            
            _context.ShoppingBags.Add(shoppingBag);
            _context.SaveChanges();
        }
    }
}
