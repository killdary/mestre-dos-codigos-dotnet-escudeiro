using System;
using System.Globalization;
using Questao3.Interfaces;

namespace Questao3.Entidades
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {

        public ContaEspecial(int conta, double limite)
        {
            Conta = conta;
            Limite = limite;
        }

        public double Limite { get; set; }

        public override void Depositar(double Valor)
        {
            Saldo += Valor;
        }

        public void MostrarDados()
        {
            var culture = CultureInfo.CreateSpecificCulture("pt-BR");
            System.Console.WriteLine($"Conta Especial:\n"+
                                     $"--Conta:{Conta}\n"+
                                     $"--Limite:{Limite.ToString("C", culture)}\n"+
                                     $"--Saldo:{Saldo.ToString("C", culture)}\n");
        }

        public override double Sacar(double Valor)
        {

            if (!ValidarTransacaoPermitida(Valor, true))
            {
                return 0;
            }

            Saldo -= Valor;
            return Valor;
        }

        private bool ValidarTransacaoPermitida(double Valor, bool Sacar = false)
        {
            Valor = (Sacar) ? Valor * -1 : Valor;

            if (Saldo + Valor < Limite * -1)
            {
                System.Console.WriteLine($"O saldo {Saldo} após o saque do valor {Valor} será inferior ao limite permitido {Limite}.");
                return false;
            }

            return true;
        }
    }
}