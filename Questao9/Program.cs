using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("### Questão 9 ###");

            var listaDeInteiros = new List<int>();
            var random = new Random();

            for (int i = 0; i < 20; i++)
            {
                listaDeInteiros.Add(random.Next(100));
            }

            Imprimir("Imprimrir Valores:", listaDeInteiros);
            Imprimir("Imprimrir Valores ordem crescente:", listaDeInteiros.OrderBy(x => x).ToList());
            Imprimir("Imprimrir Valores ordem decrescente:", listaDeInteiros.OrderByDescending(x => x).ToList());

            ImprimirUmValor("Primeiro valor: ", listaDeInteiros.First());
            ImprimirUmValor("Último valor: ", listaDeInteiros.Last());

            listaDeInteiros.Insert(0, random.Next(100));
            Imprimir("Imprimrir lista com valor inserido na primeira posição:", listaDeInteiros);

            listaDeInteiros.Insert(listaDeInteiros.Count, random.Next(100));
            Imprimir("Imprimrir lista com valor inserido na última posição:", listaDeInteiros);

            listaDeInteiros.RemoveAt(0);
            Imprimir("Imprimrir lista com valor na primeira posição removido:", listaDeInteiros);

            listaDeInteiros.RemoveAt(listaDeInteiros.Count - 1);
            Imprimir("Imprimrir lista com valor na última posição removido:", listaDeInteiros);

            var apenasPares = listaDeInteiros.Where(x => x %2 == 0).ToList();
            Imprimir("Imprimrir apenas valores pares da lista:", apenasPares);


            var valor =  ReceberInteiroValido();
            Imprimir("Imprimrir apenas lista de valor desejado:", listaDeInteiros.Where(x => x == valor).ToList());

            ImprimirArray("Converter lista para array e imprimir:", listaDeInteiros.ToArray());
        }

        static void Imprimir(string mensagem, List<int> lista)
        {
            System.Console.WriteLine($"{mensagem} {lista.Select(x => x.ToString()).Aggregate((i, j) => i + ", " + j)}");
        }

        static void ImprimirUmValor(string mensagem, int valor){
            System.Console.WriteLine($"{mensagem} {valor}");
        }
        
        static void ImprimirArray(string mensagem, int[] array)
        {
            System.Console.WriteLine($"{mensagem} {string.Join(", ", array.ToArray())}");
        }

        static int ReceberInteiroValido(){
            int valor = 0;

            while (true)
            {
                System.Console.WriteLine("Digite um número para que será procurado:");
                var i =  Console.ReadLine();

                if (int.TryParse(i, out valor))
                {
                    break;
                }else{
                    System.Console.WriteLine("Valor informádo inválido!");
                }
            }

            return valor;
        }

    }

}
