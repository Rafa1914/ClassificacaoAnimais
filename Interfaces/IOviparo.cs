using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Interfaces
{
    public interface IOviparo
    {
        static void Botar() { Console.WriteLine("Estou botando um ovo"); }
        static void Chocar() { Console.WriteLine("Estou chocando um ovo"); }
    }
}
