using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Model;
using DAL.interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ShoppingItemRepository:IShoppingItemRepository
    {
        private readonly DataContext _context;
        public ShoppingItemRepository(DataContext context)
        {
            _context = context;
        }
        public ShoppingItem FindById(int id)
        {
            return _context.ShoppingItems.Where(s => s.ShoppingItemID == id).Single();
        }

        public void Create(ShoppingItem shoppingItem)
        {
            _context.ShoppingItems.Add(shoppingItem);
            _context.SaveChanges();
        }

        public List<ShoppingItem> FindByShoppingBagID(int id)
        {
            return _context.ShoppingItems.Where(s => s.ShoppingBagID == id)
                .Include(s => s.Product)
                .ToList();
        }

        public void Delete(ShoppingItem shoppingItem)
        {             
                _context.ShoppingItems.Remove(shoppingItem);
                _context.SaveChanges();            
        }
    }
}
