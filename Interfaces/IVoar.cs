using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Interfaces
{
    public interface IVoar
    {
        int AltitudeMaximaEmMetros { get; }
        double VelocidadeDoVoo { get; }
        static void Voar() { Console.WriteLine("Estou voando!"); }
        static void InformacoesDeVoo(IVoar voar) 
        {
            Console.WriteLine($"Altitude máxima em metros: {voar.AltitudeMaximaEmMetros} m");
            Console.WriteLine($"Velocidade de voo: {voar.VelocidadeDoVoo}");
        }
    }
}
