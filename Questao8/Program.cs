using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Questão 8 ###");

            string valor = string.Empty;
            double valorDouble;
            var listaValores = new List<double>();
            var count = 1;

            while (true)
            {
                Console.WriteLine($"Digite o {count}º valor ou digite SAIR para encerrar a aplicação:");
                valor = Console.ReadLine();

                if (string.Equals(valor, "SAIR"))
                {
                    break;
                }

                if (double.TryParse(valor, out valorDouble))
                {
                    listaValores.Add(valorDouble);
                    count++;
                }
                else{
                    Console.WriteLine("valor inválido Tente novamente");
                }
            }

            if (!listaValores.Any())
            {
                Console.WriteLine("Lista vazia, nenhum valor informado.");
            }
            else 
            {
                Console.WriteLine($"Valores crescentes: {listaValores.OrderBy(x => x).Select(x => x.ToString()).Aggregate((i, j) => i + ", " + j)}");
                Console.WriteLine($"Valores crescentes: {listaValores.OrderByDescending(x => x).Select(x => x.ToString()).Aggregate((i, j) => i + ", " + j)}");
            }


        }
    }
}
