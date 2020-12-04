using SOLID.DIP.Constracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP
{
    public class CustomerService
    {
        private ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public void Register(string name)
        {
            _repository.Save(name);
        }
    }
}
