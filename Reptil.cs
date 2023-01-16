using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais
{
    public abstract class Reptil:Animal
    {
        public bool TemEscamas { get; protected set; }
        public bool TemCasco { get; protected set; }

        public Reptil(string nome, DateTime dataDeNascimento, char sexo) : base(nome, dataDeNascimento, sexo)
        {

        }
    }
}
