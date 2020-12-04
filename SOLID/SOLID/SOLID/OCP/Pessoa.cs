using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public class Pessoa
    {
        public Pessoa(string  name)
        {
            if (name.Length<3) 
                    throw new Exception("Nome inválido");
                       
            this.Name = name;
        }
        public int Id { get; private set; }
        public string  Name { get; private set; }

        public void ChangeName(string name)
        {
            if (name.Length < 3)
                throw new Exception("Nome inválido");

            this.Name = name;
        }
    }
}
