using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais
{
    public abstract class Animal
    {
        public string Nome { get; protected set; }
        public DateTime DataDeNascimento { get; protected set; }
        public char Sexo { get; protected set; }
        public int Idade { get; protected set; }
        public bool Carnivoro { get; protected set; }
        public bool Peconhento { get; protected set; }
        public Animal(string nome, DateTime dataDeNascimento, char sexo)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Idade = DateTime.Today.Year - DataDeNascimento.Year;
        }

        public void Movimentar()
        {
            Console.WriteLine("Estou movimentando!");
        }
        public void Comunicar()
        {
            Console.WriteLine("Estou me comunicando.");
        }
        public void Alimentar()
        {
            Console.WriteLine("Estou me alimentando.");
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Data de Nascimento: {this.DataDeNascimento}");
            Console.WriteLine($"Sexo: {this.Sexo}");
            Console.WriteLine($"Idade: {this.Idade}");
            Console.WriteLine($"Carnivoro: {this.Carnivoro}");
            Console.WriteLine($"peçonhento: {this.Peconhento}");
        }
    }
}
