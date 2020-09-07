using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Questao 7 ###");
            var listaValores = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine($"Digite o {i+1}º valor:");
                listaValores.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var somaValoresPares = listaValores.Where(x => x % 2 == 0).Sum();

            System.Console.WriteLine($"A soma dos valores pares é igual a {somaValoresPares}");

        }
    }
}
