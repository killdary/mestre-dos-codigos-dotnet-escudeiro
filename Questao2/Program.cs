using System;
using System.Collections.Generic;
using System.Linq;
using DotNetEscudeiro.Questao2.Entidades;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Questão 2 ###");

            var listaFuncionario = new List<Funcionario>();

            while (true)
            {
                menu();
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        System.Console.Write("Digite o nome do funcionário: ");
                        var nome = System.Console.ReadLine();
                        System.Console.Write("Digite o salário do funcionário: ");
                        var salario = Convert.ToDecimal(System.Console.ReadLine());

                        listaFuncionario.Add(new Funcionario
                        {
                            Nome = nome,
                            Salario = salario
                        });

                        System.Console.WriteLine();
                        break;

                    case 2:
                        var maiorSalario = listaFuncionario.Select(f => f.Salario).Max();
                        var menorSalario = listaFuncionario.Select(f => f.Salario).Min();

                        System.Console.WriteLine($"O maior salário é R$ {maiorSalario}");
                        System.Console.WriteLine($"O(s) funcionáro(s) com este salário: " +
                            $"{listaFuncionario.Where(f => f.Salario == maiorSalario).Select(f => f.Nome).Aggregate((i, j) => i + ", " + j)}");

                        System.Console.WriteLine();

                        System.Console.WriteLine($"O menor salário é R$ {menorSalario}");
                        System.Console.WriteLine($"O(s) funcionáro(s) com este salário: " +
                            $"{listaFuncionario.Where(f => f.Salario == menorSalario).Select(f => f.Nome).Aggregate((i, j) => i + ", " + j)}");
                        
                        System.Console.WriteLine();
                        break;

                    default:
                        break;
                }

            }

        }

        static void menu()
        {
            System.Console.WriteLine("Selecione uma Opção:");
            System.Console.WriteLine("-- Opção 1: Cadastrar novo funcionário.");
            System.Console.WriteLine("-- Opção 2: Imprimir dados de maior e menor salário.");
            System.Console.WriteLine("-- Opção Default: Digite um opção não listada acima para sair da aplicação");
            System.Console.WriteLine("Digite uma opção: ");
        }
    }
}
