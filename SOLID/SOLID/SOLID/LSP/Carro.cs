using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP
{
    public class Carro : Veiculo
    {
        public override void LigarMotor()
        {
            base.LigarMotor();
            Console.WriteLine("Ligou o Motor (Filho)");
        }
    }
}
