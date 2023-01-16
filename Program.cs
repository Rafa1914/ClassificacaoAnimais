using ClassificacaoAnimais.Animais;
using ClassificacaoAnimais.Interfaces;

namespace ClassificacaoAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var perry = new Ornitorrinco("Perry", DateTime.Today, 'M');
            perry.Botar();
            perry.Chocar();
            perry.Movimentar();
            perry.ExibirInformacoes();
        }
    }
}