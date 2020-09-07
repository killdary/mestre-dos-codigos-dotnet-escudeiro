namespace Questao1
{
    public class Calculadora : ICalculadora
    {
        public decimal Divisao(decimal a, decimal b) => a / b;

        public decimal Multiplicacao(decimal a, decimal b) => a * b ;
        
        public decimal Soma(decimal a, decimal b) => a + b;

        public decimal Subtracao(decimal a, decimal b) => a - b;
    }
}