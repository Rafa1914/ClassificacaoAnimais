using ClassificacaoAnimais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Animais
{
    internal class DragaoDeComodo : Reptil, IOviparo
    {
        public DragaoDeComodo(string nome, DateTime dataDeNascimento, char sexo) : base(nome, dataDeNascimento, sexo)
        {

        }
        public void Botar() => IOviparo.Botar();
        public void Chocar() => IOviparo.Chocar();
    }
}
