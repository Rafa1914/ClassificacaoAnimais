using ClassificacaoAnimais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Animais
{
    internal class Morcego : Mamifero, IVoar
    {
        public Morcego(string nome, DateTime dataDeNascimento, char sexo) : base(nome, dataDeNascimento, sexo)
        {
        }
        public void Voar() => IVoar.Voar();
        public int AltitudeMaximaEmMetros { get; private set; }

        public double VelocidadeDoVoo { get; private set; }
    }
}
