using System;

namespace Questao1
{
    class Program
    {
        static Calculadora _calculadora;
        static void Main(string[] args)
        {
            _calculadora = new Calculadora();

            Console.WriteLine("### Questão 1 ###");
            System.Console.WriteLine("Digite um valor para a variável A: ");
            var a = Convert.ToDecimal(Console.ReadLine());
            
            System.Console.WriteLine("Digite um valor para a variável B: ");
            var b = Convert.ToDecimal(Console.ReadLine());


            menu();

            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        System.Console.WriteLine($"O valor da soma de {a} e {b} é: {_calculadora.Soma(a,b)}");
                        break;
                        
                    case 2:
                        System.Console.WriteLine($"O valor da subtração de {a} e {b} é: {_calculadora.Subtracao(a,b)}");
                        break;
                        
                    case 3:
                        System.Console.WriteLine($"O valor da divisão de {a} e {b} é: {_calculadora.Divisao(a,b)}");
                        break;
                        
                    case 4:
                        System.Console.WriteLine($"O valor da multiplicação de {a} e {b} é: {_calculadora.Multiplicacao(a,b)}");
                        break;
                        
                    case 5:
                        System.Console.WriteLine($"O valor {a} é {((a % 2==0) ? "par":"impar")} e {b} é {((b % 2==0) ? "par":"impar")}.");
                        break;

                    case 6:
                        System.Console.WriteLine("Digite um novo valor para a variável A: ");
                        a = Convert.ToDecimal(Console.ReadLine());
                        
                        System.Console.WriteLine("Digite um novo valor para a variável B: ");
                        b = Convert.ToDecimal(Console.ReadLine());
                        break;                        

                    case 7:
                        System.Console.Clear();
                        menu();
                        break;
                        
                    default:
                        Environment.Exit(0);
                        break;
                }

                System.Console.WriteLine("Digite uma nova opção:");
            }   
        }

        private static void menu()
        {            
            System.Console.WriteLine("Digite uma das opções abaixo para realizar uma operação:");
            System.Console.WriteLine("-- Opção 1: Somar A e B;");
            System.Console.WriteLine("-- Opção 2: Subtrair  A e B;");
            System.Console.WriteLine("-- Opção 3: Dividir A e B;");
            System.Console.WriteLine("-- Opção 4: Multiplicar A e B;");
            System.Console.WriteLine("-- Opção 5: Imprimir A e B são pares ou impares;");
            System.Console.WriteLine("-- Opção 6: Trocar Valores de A e B;");
            System.Console.WriteLine("-- Opção 7: Limpar a tela;");
            System.Console.WriteLine("-- Opção Default: Digite um opção não listada acima para sair da aplicação");
        }
    }
}
