using ClassificacaoAnimais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Animais
{
    internal class Arara : Ave, IVoar, IOviparo
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public Arara(string nome, DateTime dataDeNascimento, char sexo, bool rapina, bool corDaPena) : base(nome, dataDeNascimento, sexo, rapina, corDaPena)
        {
            this.AltitudeMaximaEmMetros = 1000;
            this.VelocidadeDoVoo = 50;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            IVoar.InformacoesDeVoo(this);
        }
        public void Botar() => IOviparo.Botar();
        public void Chocar() => IOviparo.Chocar();

        public void Voar() => IVoar.Voar();
    }
}
