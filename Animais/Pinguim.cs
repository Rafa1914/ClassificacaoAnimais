using ClassificacaoAnimais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Animais
{
    internal class Pinguim : Ave, IOviparo
    {
        public Pinguim(string nome, DateTime dataDeNascimento, char sexo, bool rapina, bool corDaPena) : base(nome, dataDeNascimento, sexo, rapina, corDaPena)
        {
        }

        public void Botar() => IOviparo.Botar();
        public void Chocar() => IOviparo.Chocar();
    }
}
