using ClassificacaoAnimais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Animais
{
    internal class Coruja : Ave, IVoar
    {
        public int AltitudeMaximaEmMetros { get; private set; }
        public double VelocidadeDoVoo { get; private set; }

        public Coruja(string nome, DateTime dataDeNascimento, char sexo, bool rapina, bool corDaPena) : base(nome, dataDeNascimento, sexo, rapina, corDaPena)
        {
            this.AltitudeMaximaEmMetros = 0;
            this.VelocidadeDoVoo = 0;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            IVoar.InformacoesDeVoo(this);
        }
        public void Voar() => IVoar.Voar();
    }
}
