using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    class Funcionario : Cadastro
    {
        protected string senha = "02adm04";

        private string Password = "gA446%QSTCwc";
        public void InfFuncionario()
        {
            Funcionario novo = new Funcionario();
            novo.CadastrarPessoa();
        }

        public string CadInfo()
        {

            Console.WriteLine();
            Console.WriteLine("Para Proseguir E Necessario Uma Senha");
            Console.WriteLine("Se Deseja Cadastrar Uma Senha Nova Digite '1'");
            Console.WriteLine("Se Deseja Usar Senha Cadastrada Digite '2'");
            Console.WriteLine();
            key = Console.ReadLine();

            switch (key)
            {
                case "1":

                    Console.WriteLine("Para Cadastrar Uma senha nova\n" +
                                      "Por Favor Digite A Senha Do Administrador:");
                    senha = Console.ReadLine();

                    if (senha == "02adm04")
                    {
                        Console.WriteLine("Digite A Nova senha");
                        Password = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Deseja Continuar Em Funcionario?");
                        key = Console.ReadLine();

                        if (key == "sim" || key == "SIM")
                        {
                            Console.WriteLine("Para Cadatrar O Salario Digite '1'");
                            Console.WriteLine("Para cadastrar O Registro Digite '2'");
                            key = Console.ReadLine();

                            switch (key)
                            {
                                case "1":
                                    double salario;
                                    Console.WriteLine("Digite O Valor Do Salario");
                                    salario = int.Parse(Console.ReadLine().ToString());
                                    Console.WriteLine();
                                    Console.WriteLine("Deseja Mudar o codigo?");
                                    key = Console.ReadLine();

                                    if (key == "sim" || key == "SIM")
                                    {
                                        int codigoFunc;
                                        Console.WriteLine("Digite o Codido Do Funcionario");
                                        codigoFunc = int.Parse(Console.ReadLine());
                                        Console.WriteLine();
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
                                    break;

                                case "2":
                                    int codigo;
                                    Console.WriteLine("Digite O Codigo Do Funcionario");
                                    codigo = int.Parse(Console.ReadLine().ToString());
                                    Console.WriteLine("Deseja Mudar o Salario?");
                                    key = Console.ReadLine();

                                    if (key == "sim" || key == "SIM")
                                    {
                                        int SalarioFunc;
                                        Console.WriteLine("Digite o Salario Do Funcionario");
                                        SalarioFunc = int.Parse(Console.ReadLine());
                                        Console.WriteLine();
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

                                    break;
                            }
                        }
                        else
                        {
                            Cadastro Pag = new Cadastro();
                            Pag.PagInicial();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("A Senha Digitada Esta Incorreta\n" +
                                          "O Programa Sera Encerrado");
                        Console.WriteLine();
                        Console.WriteLine("Encerrando O Programa");
                    }
                    break;

                case "2":
                    Console.WriteLine("Para Proseguir Por Favor \n" +
                                      "Digite A Senha Para Continuar:");
                    Password = Console.ReadLine();
                    if (Password == "gA446%QSTCwc")
                    {
                        Console.WriteLine("Teste");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("A Senha Digitada Esta Incorreta\n" +
                                          "O Programa Sera Encerrado");
                        Console.WriteLine();
                        Console.WriteLine("Encerrando O Programa");
                    }
                    break;
            }
            return key;
        }
        public void Opcoes()
        {
            Console.WriteLine("Se Deseja Cadastrar Um Funcionario Digite '1'");
            Console.WriteLine("Se Deseja Cadastrar Salario Ou Registro Digite '2'");
            key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    InfFuncionario();
                    break;

                case "2":
                    CadInfo();
                    break;
            }
        }
    }
}
