using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Animais
{
    internal class Lontra : Mamifero
    {
        public Lontra(string nome, DateTime dataDeNascimento, char sexo) : base(nome, dataDeNascimento, sexo)
        {
        }
    }
}
