using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Questao 6 ###");

            Console.WriteLine("As palavras *ref* e *out* são palavras reservados do C# para passar valortes por referência.");  
            Console.WriteLine("A diferença que ocorre nas duas é mais no sentido de passagem dos dados. O *ref* possibilita");  
            Console.WriteLine("a passagem de dados instanciando antes um valor para a váriavel antes de passa-la para o mé-");  
            Console.WriteLine("todo e recebendo valores por referência depois de executar o método. Um método que use o");
            Console.WriteLine("*ref* deve explicitamente informar a váriável junto a palavra.");

            var valor = 123;
            UsandoRef(ref valor);

            Console.WriteLine($"Valor da variavel depois de passar para o método é igual à {valor}.");

            Console.WriteLine("");  

            Console.WriteLine("Diferente de *ref*, o *out* não realiza a passagem de valores para dentro do método, ele apenas");
            Console.WriteLine("possibilita a saída de valores, sendo necessário antes do fialo do método setar o valor deseja-");
            Console.WriteLine("do para a váriável informada.");

            int valor2;
            UsandoOut(out valor2);

            Console.WriteLine($"Valor da variavel depois de passar para o método é igual à {valor2}.");

        }

        public static void UsandoRef(ref int variavel){
            Console.WriteLine($"Valor da variavela antes de passar para o método é igual à {variavel}.");
            variavel = Convert.ToInt32(Console.ReadLine());
        }

        public static void UsandoOut(out int variavel){
            variavel = Convert.ToInt32(Console.ReadLine());
        }
    }
}
