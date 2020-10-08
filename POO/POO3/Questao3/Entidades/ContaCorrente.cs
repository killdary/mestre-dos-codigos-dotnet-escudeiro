using System;
using System.Globalization;
using Questao3.Interfaces;

namespace Questao3.Entidades
{
    public class ContaCorrente : ContaBancaria, IImprimivel
    {
        public ContaCorrente(int conta, decimal taxa)
        {
            Conta = conta;
            TaxaDeOperacao = taxa;
        }

        public decimal TaxaDeOperacao { get; set; }
        public override void Depositar(decimal Valor)
        {
            if (!ValidarTransacaoPermitida(Valor))
            {
                return;
            }
            Saldo += Valor;
            AplicarTaxaDeTransacao();

        }

        public override void MostrarDados()
        {
            var culture = CultureInfo.CreateSpecificCulture("pt-BR");
            Console.WriteLine($"Conta Corrente:\n" +
                                     $"--Conta:{Conta}\n" +
                                     $"--Taxa de Operação:{TaxaDeOperacao.ToString("C", culture)}\n" +
                                     $"--Saldo:{Saldo.ToString("C", culture)}\n");
        }

        public override decimal Sacar(decimal Valor)
        {
            if (!ValidarTransacaoPermitida(Valor, true))
            {
                return 0;
            }

            AplicarTaxaDeTransacao();
            Saldo -= Valor;
            return Valor;
        }

        private bool ValidarTransacaoPermitida(decimal Valor, bool sacar = false)
        {
            if (Valor < 0)
            {
                Console.WriteLine($"O valor {Saldo} não pode ser um valor negativo.");
                return false;
            }

            Valor = (sacar) ? Valor * -1 : Valor;

            if (Saldo + Valor < TaxaDeOperacao)
            {
                Console.WriteLine($"O saldo {Saldo} após o saque do valor {Valor} será inferior a taxa de operação {TaxaDeOperacao}.");
                return false;
            }

            return true;
        }

        private void AplicarTaxaDeTransacao()
        {
            Saldo -= TaxaDeOperacao;
        }
    }
}