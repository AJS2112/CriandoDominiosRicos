using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public class PessoaFisica  : Pessoa
    {
        public PessoaFisica(string name, string cpf):
            base(name)
        {
            this.CPF = cpf;
        }
        public string CPF { get; set; }
    }
}
