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
                        Console.Write("Digite o nome do funcionário: ");
                        var nome = Console.ReadLine();
                        Console.Write("Digite o salário do funcionário: ");
                        var salario = Convert.ToDecimal(Console.ReadLine());

                        listaFuncionario.Add(new Funcionario
                        {
                            Nome = nome,
                            Salario = salario
                        });

                        Console.WriteLine();
                        break;

                    case 2:
                        var maiorSalario = listaFuncionario.Select(f => f.Salario).Max();
                        var menorSalario = listaFuncionario.Select(f => f.Salario).Min();

                        Console.WriteLine($"O maior salário é R$ {maiorSalario}");
                        Console.WriteLine($"O(s) funcionáro(s) com este salário: " +
                            $"{listaFuncionario.Where(f => f.Salario == maiorSalario).Select(f => f.Nome).Aggregate((i, j) => i + ", " + j)}");

                        Console.WriteLine();

                        Console.WriteLine($"O menor salário é R$ {menorSalario}");
                        Console.WriteLine($"O(s) funcionáro(s) com este salário: " +
                            $"{listaFuncionario.Where(f => f.Salario == menorSalario).Select(f => f.Nome).Aggregate((i, j) => i + ", " + j)}");
                        
                        Console.WriteLine();
                        break;

                    default:
                        break;
                }

            }

        }

        static void menu()
        {
            Console.WriteLine("Selecione uma Opção:");
            Console.WriteLine("-- Opção 1: Cadastrar novo funcionário.");
            Console.WriteLine("-- Opção 2: Imprimir dados de maior e menor salário.");
            Console.WriteLine("-- Opção Default: Digite um opção não listada acima para sair da aplicação");
            Console.WriteLine("Digite uma opção: ");
        }
    }
}
