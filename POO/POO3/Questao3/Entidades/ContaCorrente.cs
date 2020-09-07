using System.Globalization;
using Questao3.Interfaces;

namespace Questao3.Entidades
{
    public class ContaCorrente : ContaBancaria, IImprimivel
    {
        public ContaCorrente(int conta, double taxa)
        {
            Conta = conta;
            TaxaDeOperacao = taxa;
        }

        public double TaxaDeOperacao { get; set; }
        public override void Depositar(double Valor)
        {
            if(!ValidarTransacaoPermitida(Valor)){
                return;
            }
            Saldo += Valor;
            AplicarTaxaDeTransacao();

        }

        public void MostrarDados()
        {
            var culture = CultureInfo.CreateSpecificCulture("pt-BR");
            System.Console.WriteLine($"Conta Corrente:\n"+
                                     $"--Conta:{Conta}\n"+
                                     $"--Taxa de Operação:{TaxaDeOperacao.ToString("C", culture)}\n"+
                                     $"--Saldo:{Saldo.ToString("C", culture)}\n");
        }

        public override double Sacar(double Valor)
        {
            if(!ValidarTransacaoPermitida(Valor, true)){
                return 0;
            }

            AplicarTaxaDeTransacao();
            Saldo -= Valor;
            return Valor;
        }

        private bool ValidarTransacaoPermitida(double Valor, bool sacar = false){
            Valor = (sacar) ? Valor * -1: Valor;

            if(Saldo + Valor < TaxaDeOperacao){
                System.Console.WriteLine($"O saldo {Saldo} após o saque do valor {Valor} será inferior a taxa de operação {TaxaDeOperacao}.");
                return false;
            }
            
            return true;
        }

        private void AplicarTaxaDeTransacao(){
            Saldo -= TaxaDeOperacao;
        }
    }
}