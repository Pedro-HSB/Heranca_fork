using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    class Gerente
    {
        public string setor;
        public void Setor()
        {
            Console.WriteLine("Digite o Setor ");
            setor = Console.ReadLine();
        }
    }
}
