using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais
{
    public abstract class Ave:Animal
    {
        public bool Rapina { get; protected set; }
        public bool CorDaPena { get; protected set; }

        public void Ciscar()
        {
            Console.WriteLine("Estou ciscando!");
        }

        public override void  ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Ave de Rapina: {this.Rapina}");
            Console.WriteLine($"Cor da Pena: {this.CorDaPena}");
        }

        public Ave(string nome, DateTime dataDeNascimento, char sexo, bool rapina, bool corDaPena) : base(nome, dataDeNascimento, sexo)
        {
            Rapina = rapina;
            CorDaPena = corDaPena;
        }

        public Ave(string nome, DateTime dataDeNascimento, char sexo) : base(nome, dataDeNascimento, sexo)
        {
        }
    }
}
