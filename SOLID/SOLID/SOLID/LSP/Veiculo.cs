using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP
{
    public abstract class Veiculo
    {
        public virtual void LigarMotor() {
            Console.WriteLine("Ligou o Motor (PAI)");
        }
        public void Acelerar() {
            Console.WriteLine("Acelerou (PAI)");
        }
    }
}
