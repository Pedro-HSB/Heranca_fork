using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    class Coordenador : Cadastro
    {
        public string CadastroEquipes()
        {
            string NomeEquipe;

            string CordEquipe;

            Console.WriteLine("Qual o Nome Da Equipe?");
            NomeEquipe = Console.ReadLine();

            Console.WriteLine("Quem e o Responsavel Por Essa Equipe?");
            CordEquipe = Console.ReadLine();

            Console.WriteLine("Deseja Adicionar Alguem a Equipe?");
            key = Console.ReadLine();
            if (key == "sim")
            {
                Console.WriteLine("Qual o Nome Do Funcionario?");
                nome = Console.ReadLine();
            }
            else
            {
                string AreaEquipe;

                Console.WriteLine("Qual Area Essa Equipe Esta");
                AreaEquipe = Console.ReadLine();

                Console.WriteLine("Deseja Cadastrar Um Coordenador");
                key = Console.ReadLine();

                if(key =="sim" || key =="SIM")
                {
                    Cadastro Coorde = new Cadastro();
                    Console.WriteLine();
                    Coorde.CadastrarPessoa();
                }
            }
            return finish;
        }

        public string Opcoes()
        {
            Console.WriteLine("Deseja cadastrar Uma Equipe nova ?");
            key = Console.ReadLine();
            if (key == "sim")
            {
                return CadastroEquipes();
            }
            else
            {
                Cadastro Pag = new Cadastro();
                Pag.PagInicial();

                return finish;
            }

        }

    }
}
