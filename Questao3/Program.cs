using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Questão 3 ###");


            Console.WriteLine("Os múltiplos de 3 são: ");
            int count = 1;
            while (count <= 100)
            {
                if(count % 3 == 0)
                    System.Console.Write($"{count}, ");
                count++;
            }
        }
    }
}
