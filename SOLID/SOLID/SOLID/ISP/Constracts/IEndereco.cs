using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Constracts
{
    public interface IEndereco
    {
         string Cidade { get; set; }
         string Estado { get; set; }
         string  Pais { get; set; }
    }
}
