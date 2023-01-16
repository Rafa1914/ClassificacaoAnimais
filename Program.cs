using ClassificacaoAnimais.Animais;
using ClassificacaoAnimais.Interfaces;

namespace ClassificacaoAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //var arara = new Arara();
            //arara.ExibirInformacoes();

            var perry = new Ornitorrinco("Perry", DateTime.Today, 'M');
            perry.Botar();
        }
    }
}