using System;
using System.Globalization;
using Questao3.Interfaces;

namespace Questao3.Entidades
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {

        public ContaEspecial(int conta, decimal limite)
        {
            Conta = conta;
            Limite = limite;
        }

        public decimal Limite { get; set; }

        public override void Depositar(decimal Valor)
        {
            Saldo += Valor;
        }

        public override void MostrarDados()
        {
            var culture = CultureInfo.CreateSpecificCulture("pt-BR");
            Console.WriteLine($"Conta Especial:\n"+
                                     $"--Conta:{Conta}\n"+
                                     $"--Limite:{Limite.ToString("C", culture)}\n"+
                                     $"--Saldo:{Saldo.ToString("C", culture)}\n");
        }

        public override decimal Sacar(decimal Valor)
        {

            if (!ValidarTransacaoPermitida(Valor, true))
            {
                return 0;
            }

            Saldo -= Valor;
            return Valor;
        }

        private bool ValidarTransacaoPermitida(decimal Valor, bool Sacar = false)
        {
            Valor = (Sacar) ? Valor * -1 : Valor;

            if (Saldo + Valor < Limite * -1)
            {
                Console.WriteLine($"O saldo {Saldo} após o saque do valor {Valor} será inferior ao limite permitido {Limite}.");
                return false;
            }

            return true;
        }
    }
}