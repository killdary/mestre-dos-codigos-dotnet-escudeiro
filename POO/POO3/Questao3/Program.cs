using System;
using Questao3.Entidades;

namespace Questao3
{
    class Program
    {
        private static ContaBancaria conta = null;
        static void Main(string[] args)
        {
            Console.WriteLine("### POO - Questão 3 ###");
            var ContaCorrente1 = new ContaCorrente(1230, 10);
            var ContaCorrente2 = new ContaCorrente(1231, 25);
            var ContaEspecial1 = new ContaEspecial(1234, 650);
            var ContaEspecial2 = new ContaEspecial(1232, 500);

            System.Console.WriteLine("*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*");
            System.Console.WriteLine("#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#");
            System.Console.WriteLine("*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*");
            System.Console.WriteLine("#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#");
            System.Console.WriteLine("██████╗░░█████╗░███╗░░██╗░█████╗░░█████╗░  ██████╗░██████╗░░░███╗░░");
            System.Console.WriteLine("██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗░████║░░");
            System.Console.WriteLine("██████╦╝███████║██╔██╗██║██║░░╚═╝██║░░██║  ██║░░██║██████╦╝██╔██║░░");
            System.Console.WriteLine("██╔══██╗██╔══██║██║╚████║██║░░██╗██║░░██║  ██║░░██║██╔══██╗╚═╝██║░░");
            System.Console.WriteLine("██████╦╝██║░░██║██║░╚███║╚█████╔╝╚█████╔╝  ██████╔╝██████╦╝███████╗");
            System.Console.WriteLine("╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░░╚════╝░  ╚═════╝░╚═════╝░╚══════╝");
            System.Console.WriteLine("#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#");
            System.Console.WriteLine("*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*");
            System.Console.WriteLine("#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#");
            System.Console.WriteLine("*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*");


            menu();

            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        SelecionarTipoDeConta();
                        break;

                    case 2:
                        Extrato();
                        break;

                    case 3:
                        Sacar();
                        break;

                    case 4:
                        Depositar();
                        break;

                    case 5:
                        Console.Clear();
                        menu();
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("Digite uma nova opção:");
            }









            System.Console.WriteLine("###################################################################");
            System.Console.WriteLine("Contas");

            ContaCorrente1.MostrarDados();
            ContaCorrente2.MostrarDados();
            ContaEspecial1.MostrarDados();
            ContaEspecial2.MostrarDados();

            System.Console.WriteLine("###################################################################");
            System.Console.WriteLine("Deposito R$ 1000,00");

            ContaCorrente1.Depositar(1000);
            ContaCorrente2.Depositar(1000);
            ContaEspecial1.Depositar(1000);
            ContaEspecial2.Depositar(1000);

            System.Console.WriteLine("###################################################################");
            System.Console.WriteLine("Saldo");

            ContaCorrente1.MostrarDados();
            ContaCorrente2.MostrarDados();
            ContaEspecial1.MostrarDados();
            ContaEspecial2.MostrarDados();

            System.Console.WriteLine("###################################################################");
            System.Console.WriteLine("Saque R$ 500,00");

            ContaCorrente1.Sacar(500);
            ContaCorrente2.Sacar(500);
            ContaEspecial1.Sacar(500);
            ContaEspecial2.Sacar(500);

            System.Console.WriteLine("###################################################################");
            System.Console.WriteLine("Saldo");

            ContaCorrente1.MostrarDados();
            ContaCorrente2.MostrarDados();
            ContaEspecial1.MostrarDados();
            ContaEspecial2.MostrarDados();

            System.Console.WriteLine("###################################################################");
            System.Console.WriteLine("Saque R$ 1000,00");

            ContaCorrente1.Sacar(1000);
            ContaCorrente2.Sacar(1000);
            ContaEspecial1.Sacar(1000);
            ContaEspecial2.Sacar(1000);

            System.Console.WriteLine("###################################################################");
            System.Console.WriteLine("Saldo");

            ContaCorrente1.MostrarDados();
            ContaCorrente2.MostrarDados();
            ContaEspecial1.MostrarDados();
            ContaEspecial2.MostrarDados();
        }

        private static void Extrato()
        {
            if (conta == null)
            {
                Console.WriteLine("è necessário cinformar a contariar uma conta antes.");
                return;
            }
            conta.MostrarDados();
        }
        private static void SelecionarTipoDeConta()
        {
            Console.WriteLine("Digite a agencia:");
            var agencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a conta:");
            var numeroConta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecione o Tipo de Conta:");
            Console.WriteLine("-- Opção 1: Conta Corrente;");
            Console.WriteLine("-- Opção 2: Conta Especial;");
            Console.WriteLine("-- Opção Default: Digite um opção não listada acima para voltar ao menu");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    conta = new ContaCorrente(agencia, numeroConta);
                    break;

                case 2:
                    conta = new ContaEspecial(agencia, numeroConta);
                    break;

                default:
                    break;
            }
        }

        private static void Sacar()
        {
            if (conta == null)
            {
                Console.WriteLine("è necessário cinformar a contariar uma conta antes.");
                return;
            }

            decimal valor = ReceberValor();
            while (Convert.ToDecimal(Console.ReadLine()) < 0)
            {

            }
            var valorSacado = conta.Sacar(valor);
            if (valorSacado >= 0)
            {
                Console.WriteLine("Saldo insuficiente ou valor informado inválido.");
            }
            else
            {
                Console.WriteLine($"Valor Sacado: R$ {valorSacado}");
            }
        }
        private static void Depositar()
        {
            if (conta == null)
            {
                Console.WriteLine("è necessário cinformar a contariar uma conta antes.");
                return;
            }

            decimal valor = ReceberValor();
            conta.Depositar(valor);
            Console.WriteLine("Operacao Realizada.");
            conta.MostrarDados();
        }

        private static decimal ReceberValor()
        {
            bool flag = true;
            decimal valor = 0;
            while (flag)
            {
                Console.WriteLine("Digite um valor maior que 0:");
                valor = Convert.ToDecimal(Console.ReadLine());
                if (valor > 0)
                {
                    flag = false;
                }
            }
            return valor;
        }


        private static void menu()
        {
            Console.WriteLine("Digite uma das opções abaixo para realizar uma operação:");
            Console.WriteLine("-- Opção 1: Selecionar tipo de conta Corrente ou Especial;");
            Console.WriteLine("-- Opção 2: Extrato;");
            Console.WriteLine("-- Opção 3: Sacar;");
            Console.WriteLine("-- Opção 4: Depositar;");
            Console.WriteLine("-- Opção 5: Limpar a tela;");
            Console.WriteLine("-- Opção Default: Digite um opção não listada acima para sair da aplicação");
        }
    }
}
