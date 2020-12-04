using SOLID.ISP.Constracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP
{
    class NotaFiscal : IPedido, IEndereco
    {
        public DateTime Data { get ; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public void RealizarPedido()
        {
            throw new NotImplementedException();
        }
    }
}
