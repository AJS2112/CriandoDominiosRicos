using SOLID.DIP;
using SOLID.DIP.Constracts;
using SOLID.ISP;
using SOLID.LSP;
using SOLID.OCP;
using SOLID.SRP;
using SOLID.SRP.Repository;
using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SRP
            //Fornecedor fornecedor = new Fornecedor();
            //fornecedor.ChangeName("Antonio");

            //IFornecedorRepository rep = new FornecedorRepository();
            //rep.Save(fornecedor);
            #endregion

            #region OCP
            //var p = new Pessoa("Antonio");
            //p.ChangeName("Antonio Sucre");
            //var pf = new PessoaFisica("Antonio", "70870129244");
            #endregion

            #region LSP
            //var veiculo = new Carro();
            //veiculo.LigarMotor();
            #endregion

            #region ISP
            //NotaFiscal nf = new NotaFiscal();
            //nf.RealizarPedido();
            #endregion

            #region DIP
            var rep = new CustomerRepository();
            CustomerService customerService = new CustomerService(rep);
            #endregion

            Console.ReadKey();
        }
    }
}
