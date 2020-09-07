namespace Questao1.Interfaces
{
    public interface ICalculadora
    {         
         decimal Divisao(decimal a, decimal b);

         decimal Multiplicacao(decimal a, decimal b);

         decimal Soma(decimal a, decimal b);

         decimal Subtracao(decimal a, decimal b);

         bool VerificarPar(decimal a);
    }
}