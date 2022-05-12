using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    class Cordenador : Pessoa
    {
        string key;

        public string CadastroEquipes()
        {
            string NomeEquipe;

            string CordEquipe;

            return CadastroEquipes();
            Console.WriteLine("Qual o Nome Da Equipe?");
            NomeEquipe = Console.ReadLine();

            Console.WriteLine("Quem e o Responsavel Por Essa Equipe?");
            CordEquipe = Console.ReadLine();

            Console.WriteLine("Deseja Adicionar Alguem a Equipe?");
            key = Console.ReadLine();
            if (key == "sim")
            {
                string funcionario;
                Console.WriteLine("Qual o Nome Do Funcionario?");
                funcionario = Console.ReadLine();
            }
        }

        public string Equipe()
        {
            return Equipe();
            Console.WriteLine("Deseja cadastrar Uma Equipe nova ?");
            key = Console.ReadLine();
            if (key == "sim")
            {
                return CadastroEquipes();
            }
        }

    }
}
