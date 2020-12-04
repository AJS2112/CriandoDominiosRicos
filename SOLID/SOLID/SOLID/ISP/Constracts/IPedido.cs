using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Constracts
{
    public interface IPedido
    {
        public DateTime Data { get; set; }

        public void RealizarPedido();
    }
}
