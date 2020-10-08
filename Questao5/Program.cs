using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Questao 5 ###");

            Console.WriteLine("Digite um valor para A: ");
            var a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite um valor para B: ");
            var b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para C: ");
            var c = Convert.ToDouble(Console.ReadLine());

            var delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta >= 0)
            {
                Console.WriteLine($"x1 = { (-b + Math.Sqrt(delta)) / 2 * a}");
                Console.WriteLine($"x2 = { (-b - Math.Sqrt(delta)) / 2 * a}");
            }
            else
            {
                Console.WriteLine("O valor de delta é menor que 0.");
            }
        }
    }
}
