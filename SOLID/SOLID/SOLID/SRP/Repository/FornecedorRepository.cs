using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public void Save(Fornecedor fornecedor)
        {
            Console.WriteLine("Fornecedor Saved");
        }
    }
}
