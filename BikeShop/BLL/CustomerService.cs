using BLL.interfaces;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository repository;
        public CustomerService(ICustomerRepository _repository)
        {
            repository = _repository;
        }

        public Customer FindById(int id)
        {
            return repository.FindById(id);
        }
    }
}
