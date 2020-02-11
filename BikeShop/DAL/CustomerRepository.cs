using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository( DataContext context)
        {
            _context = context;
        }
        public Customer FindById(int id)
        {
            return _context.Customers.Where(c => c.CustomerID == id).Single();
        }
    }
}
