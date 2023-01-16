using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais
{
    public abstract class Mamifero:Animal
    {
        public int QtdDeMamas { get; protected set; }
        public bool Pelos { get; protected set; }
        public string CorDoPelo { get; protected set; }

        public Mamifero(string nome, DateTime dataDeNascimento, char sexo): base(nome, dataDeNascimento, sexo)
        {

        }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Quantidade de mamas: {this.QtdDeMamas}");
            Console.WriteLine($"Pelos: {this.Pelos}");
            Console.WriteLine($"Cor do pelo: {this.CorDoPelo}");
        }
        public void Amamentar()
        {
            Console.WriteLine("Estou amamentando.");
        }
    }
}
