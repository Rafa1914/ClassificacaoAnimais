using ClassificacaoAnimais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Animais
{
    internal class Ornitorrinco : Mamifero, IAquatico, IOviparo
    {
        public Ornitorrinco(string nome, DateTime dataDeNascimento, char sexo) : base(nome, dataDeNascimento, sexo)
        {
        }

        public bool ViveEmTerra { get; private set; }

        public bool Mergulho { get; private set; }

        public bool AguaDoce { get; private set; }

        public void Botar() => IOviparo.Botar();
        public void Chocar() => IOviparo.Chocar();

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            IAquatico.InformacoesAquaticas(this);
        }
    }
}
