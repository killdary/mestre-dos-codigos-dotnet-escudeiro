namespace Questao1
{
    public class Calculadora : ICalculadora
    {
        public double Divisao(double a, double b) => a / b;

        public double Multiplicacao(double a, double b) => a * b ;
        
        public double Soma(double a, double b) => a + b;

        public double Subtracao(double a, double b) => a - b;
    }
}