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
            Console.WriteLine("Para Cadastrar Setor  Digite '2' ");
            Console.WriteLine("Para Cadastrar Equipe  Digite '3' ");
            Console.WriteLine();
            chave = int.Parse(Console.ReadLine());

            if (chave == 1)
            {
                Console.WriteLine();
                Pessoa nome = new Pessoa();
                nome.CadastrarNome();
                nome.ExibirInfo();
                Console.ReadKey();
            }
            if (chave == 2)
            {
                Console.WriteLine("teste2");
                Console.ReadKey();
            }
            if (chave == 3)
            {
                Gerente equipe = new Gerente();

                Console.ReadKey();
            }
            return chave;
        }
    }
}
