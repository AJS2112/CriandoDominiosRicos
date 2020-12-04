using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Constracts
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Save(string name)
        {
            Console.WriteLine("Saved: "+name);
        }
    }
}
