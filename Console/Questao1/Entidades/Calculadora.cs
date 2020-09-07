using Questao1.Interfaces;

namespace Questao1.Entidades
{
    public class Calculadora : ICalculadora
    {
        public decimal Divisao(decimal a, decimal b) => a / b;

        public decimal Multiplicacao(decimal a, decimal b) => a * b ;
        
        public decimal Soma(decimal a, decimal b) => a + b;

        public decimal Subtracao(decimal a, decimal b) => a - b;

        public bool VerificarPar(decimal a) => a % 2 == 0;
    }
}