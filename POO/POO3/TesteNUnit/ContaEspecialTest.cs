using NUnit.Framework;
using Questao3.Entidades;

namespace TesteNUnit
{
    public class ContaEspecialTest
    {
        
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void DeveCriarUmaConta(){
            var conta = new ContaEspecial(1234, 1000);
            Assert.NotNull(conta);
        }

        [TestCase(1000, 530, 600)]
        [TestCase(1000, 500, 700)]
        [TestCase(1000, 1010, 1500)]
        public void DeveSacarDinheiroCasoTenhaSaldoEDescontarATaxa(double limite, double saldo, double saque){
            var conta = new ContaEspecial(1234, limite);
            conta.Saldo = saldo;
            Assert.AreEqual(saque, conta.Sacar(saque));
        }

        [TestCase(1000, -350, 500, 150)]
        [TestCase(650, 100, 490, 590)]
        [TestCase(100, 1000,  995, 1995)]
        public void DeveDepositar(double limite, double saldo, double deposito, double valorEsperado){
            var conta = new ContaEspecial(1234, limite);
            conta.Saldo = saldo;
            conta.Depositar(deposito);
            Assert.AreEqual(valorEsperado, conta.Saldo);
        }
        
        [TestCase(1000, -350,  5150, 0)]
        [TestCase(650,  100,  5000, 0)]
        [TestCase(100,  1000, 10000, 0)]
        public void NaoDeveSacarContaNaoTemSaldoMesmoComLimite(double limite, double saldo, double saque, double valorEsperado){
            var conta = new ContaEspecial(1234, limite);
            conta.Saldo = saldo;
            Assert.AreEqual(valorEsperado, conta.Sacar(saque));
        }
    }
}