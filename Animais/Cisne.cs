using ClassificacaoAnimais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Animais
{
    internal class Cisne : Ave, IOviparo, IAquatico
    {
        public bool ViveEmTerra { get; private set; }

        public bool Mergulho { get; private set; }

        public bool AguaDoce { get; private set; }
        public Cisne(string nome, DateTime dataDeNascimento, char sexo, bool rapina, bool corDaPena) : base(nome, dataDeNascimento, sexo, rapina, corDaPena)
        {
            ViveEmTerra = true;
            Mergulho = false;
            AguaDoce = true;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            IAquatico.InformacoesAquaticas(this);
        }
        public void Botar() => IOviparo.Botar();
        public void Chocar() => IOviparo.Chocar();

    }
}
