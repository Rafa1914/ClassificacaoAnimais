using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoAnimais.Interfaces
{
    public interface IAquatico
    {
        bool ViveEmTerra { get;  }
        bool Mergulho { get;  }
        bool AguaDoce { get; }

        static void InformacoesAquaticas(IAquatico animal)
        {
            Console.WriteLine($"Vive em terra: {animal.ViveEmTerra}");
            Console.WriteLine($"Mergulha: {animal.Mergulho}");
            Console.WriteLine($"Agua doce: {animal.AguaDoce}");
        }
    }
}
