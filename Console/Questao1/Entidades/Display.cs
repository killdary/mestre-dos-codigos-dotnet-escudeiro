using System;
using Questao1.Interfaces;

namespace Questao1.Entidades
{
    public class Display : IDisplay
    {
        ICalculadora _calculadora;

        public Display(ICalculadora calculadora)
        {
            _calculadora = calculadora;
        }


        public void Divisao(decimal a, decimal b)
        {
            System.Console.WriteLine($"O valor da divisão de {a} e {b} é: {_calculadora.Divisao(a, b)}");
        }

        public void Multiplicacao(decimal a, decimal b)
        {
            System.Console.WriteLine($"O valor da multiplicação de {a} e {b} é: {_calculadora.Multiplicacao(a, b)}");
        }

        public void Soma(decimal a, decimal b)
        {
            System.Console.WriteLine($"O valor da soma de {a} e {b} é: {_calculadora.Soma(a, b)}");
        }

        public void Subtracao(decimal a, decimal b)
        {
            System.Console.WriteLine($"O valor da subtração de {a} e {b} é: {_calculadora.Subtracao(a, b)}");
        }

        public void VerificarSeEPar(decimal a, decimal b)
        {
            System.Console.WriteLine($"O valor {a} é {((a % 2 == 0) ? "par" : "impar")} e {b} é {((b % 2 == 0) ? "par" : "impar")}.");
        }
    }
}