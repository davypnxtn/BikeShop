using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface ICustomerRepository
    {
        Customer FindById(int id);
    }
}
