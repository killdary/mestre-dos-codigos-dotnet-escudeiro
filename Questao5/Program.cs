using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Questao 5 ###");

            System.Console.WriteLine("Digite um valor para A: ");
            var a = Convert.ToDecimal(Console.ReadLine());
            
            System.Console.WriteLine("Digite um valor para B: ");
            var b = Convert.ToDecimal(Console.ReadLine());

            System.Console.WriteLine("Digite um valor para C: ");
            var c = Convert.ToDecimal(Console.ReadLine());

            var delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta >= 0)
            {
                System.Console.WriteLine($"x1 = { (-b + Math.Sqrt(delta)) / 2 * a}");
                System.Console.WriteLine($"x2 = { (-b - Math.Sqrt(delta)) / 2 * a}");
            }
            else
            {
                System.Console.WriteLine("O valor de delta é menor que 0.");
            }
        }
    }
}
