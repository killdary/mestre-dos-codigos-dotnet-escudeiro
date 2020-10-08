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
            Console.WriteLine("Digite um valor para a variável A: ");
            var a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite um valor para a variável B: ");
            var b = Convert.ToDouble(Console.ReadLine());


            menu();

            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        RealizarSoma(a, b);
                        break;

                    case 2:
                        RealizarSubtracao(a, b);
                        break;

                    case 3:
                        RealizarDivisao(a, b);
                        break;

                    case 4:
                        RealizarMultiplicacao(a, b);
                        break;

                    case 5:
                        VerificarSeEParOuImpar(a, b);
                        break;

                    case 6:
                        a = NovoValorDeA();
                        b = NovoValorDeB();
                        break;

                    case 7:
                        Console.Clear();
                        menu();
                        break;
                        
                    default:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("Digite uma nova opção:");
            }   
        }

        private static double NovoValorDeB()
        {
            double b;
            Console.WriteLine("Digite um novo valor para a variável B: ");
            b = Convert.ToDouble(Console.ReadLine());
            return b;
        }

        private static double NovoValorDeA()
        {
            double a;
            Console.WriteLine("Digite um novo valor para a variável A: ");
            a = Convert.ToDouble(Console.ReadLine());
            return a;
        }

        private static void VerificarSeEParOuImpar(double a, double b)
        {
            Console.WriteLine($"O valor {a} é {((a % 2 == 0) ? "par" : "impar")} e {b} é {((b % 2 == 0) ? "par" : "impar")}.");
        }

        private static void RealizarMultiplicacao(double a, double b)
        {
            Console.WriteLine($"O valor da multiplicação de {a} e {b} é: {_calculadora.Multiplicacao(a, b)}");
        }

        private static void RealizarDivisao(double a, double b)
        {
            Console.WriteLine($"O valor da divisão de {a} e {b} é: {_calculadora.Divisao(a, b)}");
        }

        private static void RealizarSubtracao(double a, double b)
        {
            Console.WriteLine($"O valor da subtração de {a} e {b} é: {_calculadora.Subtracao(a, b)}");
        }

        private static void RealizarSoma(double a, double b)
        {
            Console.WriteLine($"O valor da soma de {a} e {b} é: {_calculadora.Soma(a, b)}");
        }

        private static void menu()
        {            
            Console.WriteLine("Digite uma das opções abaixo para realizar uma operação:");
            Console.WriteLine("-- Opção 1: Somar A e B;");
            Console.WriteLine("-- Opção 2: Subtrair  A e B;");
            Console.WriteLine("-- Opção 3: Dividir A e B;");
            Console.WriteLine("-- Opção 4: Multiplicar A e B;");
            Console.WriteLine("-- Opção 5: Imprimir A e B são pares ou impares;");
            Console.WriteLine("-- Opção 6: Trocar Valores de A e B;");
            Console.WriteLine("-- Opção 7: Limpar a tela;");
            Console.WriteLine("-- Opção Default: Digite um opção não listada acima para sair da aplicação");
        }
    }
}
