using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP.Repository
{
    public interface IFornecedorRepository
    {
        void Save(Fornecedor fornecedor);
    }
}
