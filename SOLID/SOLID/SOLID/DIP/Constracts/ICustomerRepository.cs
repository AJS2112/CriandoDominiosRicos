using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Constracts
{
    public interface ICustomerRepository
    {
        void Save(string name);
    }
}
