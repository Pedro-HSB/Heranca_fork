using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    internal class TelaPrincipal
    {

        public int main ()
        {

            int chave;

            Console.WriteLine("Escolha Qual Operacao Deseja fazer");
            Console.WriteLine();
            Console.WriteLine("Para Cadastrar Funcionario Digite '1' ");
            Console.WriteLine("Para Cadastrar Cliente Digite '2' ");
            Console.WriteLine("Para Cadastrar Coordenador Digite '3' ");
            Console.WriteLine("Para Cadastrar Supervisor Digite '4' ");
            Console.WriteLine("Para Cadastrar Gerente Digite '5' ");
            Console.WriteLine("Para Cadastrar Setor  Digite '6' ");
            Console.WriteLine("Para Cadastrar Equipe  Digite '7' ");
            Console.WriteLine();
            chave = int.Parse(Console.ReadLine());

            switch (chave)
            {
                case 1:
                    Console.WriteLine();
                    Funcionario novo = new Funcionario();
                    novo.Opcoes();
                    break;

                    case 2:
                    Cliente Cadast = new Cliente();
                    Cadast.CadastrarPessoa();

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 7:
                    Coordenador equipe = new Coordenador();
                    equipe.Opcoes();
                    break;
            }
            return chave;
        }
    }
}
