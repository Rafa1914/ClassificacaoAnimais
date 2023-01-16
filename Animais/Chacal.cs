using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Animais
{
    public class Chacal:Mamifero
    {
        public Chacal(string nome, DateTime dataDeNascimento, char sexo, string corDoPelo) : base(nome, dataDeNascimento, sexo)
        {
            this.Carnivoro = true;
            this.Peconhento = false;
            this.Pelos = true;
            this.QtdDeMamas = 4;
            this.CorDoPelo = corDoPelo;
        }
    }
}
