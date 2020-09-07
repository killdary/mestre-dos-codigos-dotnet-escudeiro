namespace Questao3.Entidades
{
    public abstract class  ContaBancaria
    {
        public int Conta { get; set; }
        public double Saldo { get; set; }

        public abstract double Sacar(double valor);
        public abstract void Depositar(double valor);
    }
}