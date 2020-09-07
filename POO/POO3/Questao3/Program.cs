using System;
using Questao3.Entidades;

namespace Questao3
{
    class Program
    {
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
    }
}
