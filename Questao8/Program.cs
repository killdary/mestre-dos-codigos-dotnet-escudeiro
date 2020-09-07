using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("### Questão 8 ###");

            string valor = string.Empty;
            decimal valorDecimal;
            var listaValores = new List<decimal>();
            var count = 1;

            while (true)
            {
                System.Console.WriteLine($"Digite o {count}º valor ou digite SAIR para encerrar a aplicação:");
                valor = Console.ReadLine();

                if (string.Equals(valor, "SAIR"))
                {
                    break;
                }

                if (decimal.TryParse(valor, out valorDecimal))
                {
                    listaValores.Add(valorDecimal);
                    count++;
                }
                else{
                    System.Console.WriteLine("valor inválido Tente novamente");
                }
            }

            if (!listaValores.Any())
            {
                System.Console.WriteLine("Lista vazia, nenhum valor informado.");
            }
            else 
            {
                System.Console.WriteLine($"Valores crescentes: {listaValores.OrderBy(x => x).Select(x => x.ToString()).Aggregate((i, j) => i + ", " + j)}");
                System.Console.WriteLine($"Valores crescentes: {listaValores.OrderByDescending(x => x).Select(x => x.ToString()).Aggregate((i, j) => i + ", " + j)}");
            }


        }
    }
}
