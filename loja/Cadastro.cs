using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    internal class Cadastro : Pessoa
    {
        public string key;

        public string finish = "Encerrando O Programa";

        public void PagInicial()
        {
            Console.WriteLine("Deseja Voltar A Tela Principal ?");
            key = Console.ReadLine();
            if (key == "sim")
            {
                TelaPrincipal Principal = new TelaPrincipal();
                Principal.main();
            }
            else
            {
                Console.WriteLine("Encerrando O Programa");
            }
        }
        public void CadastrarPessoa()
        {

            Console.WriteLine("Deseja Fazer Um Cadastro ?");
            key = Console.ReadLine();

            if (key == "sim" || key == "SIM")
            {
                Pessoa cadastra = new Pessoa();

                Console.WriteLine("Digite seu nome");
                nome = Console.ReadLine().ToUpper();

                Console.WriteLine("Digite seu telefone");
                telefone = int.Parse(Console.ReadLine().ToUpper());

                Console.WriteLine("Digite seu email");
                email = Console.ReadLine().ToUpper();

                Console.WriteLine("Digite seu cpf");
                cpf = Console.ReadLine().ToUpper();

                Console.WriteLine("Digite sua data de nascimento");
                datanascimento = int.Parse(Console.ReadLine().ToUpper());
            }
            else
            {
                Console.WriteLine("Deseja Voltar A Tela Principal ?");
                key = Console.ReadLine();
                if (key == "sim")
                {
                    TelaPrincipal Principal = new TelaPrincipal();
                    Principal.main();
                }
                if (key == "nao")
                {
                    Console.WriteLine("Deseja Continuar Em Cadastrar?");
                    key = Console.ReadLine();
                    if (key == "sim")
                    {
                        ExibirInfo();
                    }
                    else
                    {
                        Console.WriteLine("Encerrando O Programa");
                    }
                }
            }
        }
        public string ExibirInfo()
        {

            Console.WriteLine("Deseja Exibir As Informacoes Cadastradas ?");
            key = Console.ReadLine();

            switch (key)
            {
                case "sim":
                    Console.WriteLine("Nome: " + nome);
                    Console.WriteLine("email: " + email);
                    Console.WriteLine("cpf: " + cpf);
                    Console.WriteLine("telefone: " + telefone);
                    Console.WriteLine("Data De Nascimento: " + datanascimento);
                    Console.WriteLine();
                    Console.WriteLine("Deseja Alterar Alguma Informacao?");
                    key = Console.ReadLine();
                    if (key == "sim" || key == "NAO")
                    {
                        string alteracao;
                        Console.WriteLine();
                        Console.WriteLine("Qual Informacao Deseja Alterar?");
                        Console.WriteLine("Nome\n" +
                                          "Telefone\n" +
                                          "Email\n" +
                                          "Cpf\n" +
                                          "Data De Nascimento\n" +
                                          "Caso Nao Deseje Alterar Digite:'nao' ");
                        Console.WriteLine();
                        alteracao = Console.ReadLine();
                        switch (alteracao)
                        {
                            case "nome":
                                Console.WriteLine("Qual o Novo Nome ?");
                                _ = (new string[1] { Console.ReadLine().ToUpper() });
                                Console.WriteLine();
                                Console.WriteLine("Nome: " + nome[1]);
                                break;

                            case "telefone":
                                Console.WriteLine("Qual o Novo Telelfone ?");
                                _ = (new int[1] { int.Parse(Console.ReadLine().ToUpper()) });
                                break;

                            case "email":
                                Console.WriteLine("Qual o Novo Email ?");
                                email = Console.ReadLine().ToUpper();
                                break;

                            case "cpf":
                                Console.WriteLine("Qual o Novo cpf ?");
                                cpf = Console.ReadLine().ToUpper();
                                break;

                            case "data de nascimento,Data De Nascimento":
                                Console.WriteLine("Qual a Nova Data De Nascimento ?");
                                datanascimento = int.Parse(Console.ReadLine().ToUpper());
                                break;

                            case "nao":
                                Console.WriteLine();
                                Console.WriteLine("Deseja Fazer Outra Operacao?");
                                key = Console.ReadLine();
                                if (key == "sim")
                                {
                                    Console.WriteLine();
                                    TelaPrincipal Principal = new TelaPrincipal();
                                    Principal.main();
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("Encerrando O Programa");
                                }
                                break;
                        }
                    }
                    break;

                case "nao":
                    Console.WriteLine("Deseja Voltar A Tela Principal ?");
                    key = Console.ReadLine();
                    if (key == "sim")
                    {
                        TelaPrincipal Principal = new TelaPrincipal();
                        Principal.main();
                    }
                    if (key == "nao")
                    {
                        Console.WriteLine("Deseja Cadastrar Outra Pessoa?");
                        key = Console.ReadLine();
                        if (key == "sim")
                        {
                            return ExibirInfo();
                        }
                        else
                        {
                            Console.WriteLine("Encerrando O Programa");
                        }
                    }
                    break;
            }
            return key;
        }
    }
}