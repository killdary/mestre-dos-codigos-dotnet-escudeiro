using Questao3.Interfaces;

namespace Questao3.Entidades
{
    public abstract class  ContaBancaria: IImprimivel
    {
        public int Conta { get; set; }
        public decimal Saldo { get; set; }

        public abstract decimal Sacar(decimal valor);
        public abstract void Depositar(decimal valor);
        public abstract void MostrarDados();
    }
}