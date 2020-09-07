using NUnit.Framework;
using Questao3.Entidades;

namespace TesteNUnit
{
    public class ContaCorrenteTest
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void DeveCriarUmaConta(){
            var conta = new ContaCorrente(1234, 10);
            Assert.NotNull(conta);
        }

        [TestCase(15, 530, 500)]
        [TestCase(10, 500, 100)]
        [TestCase(5, 1010, 1000)]
        public void DeveSacarDinheiroCasoTenhaSaldoEDescontarATaxa(double taxa, double saldo, double saque){
            var conta = new ContaCorrente(1234, taxa);
            conta.Saldo = saldo;
            Assert.AreEqual(saque, conta.Sacar(saque));
        }

        [TestCase(15, 515, 500)]
        [TestCase(10, 500, 490)]
        [TestCase(5, 1000, 995)]
        public void DeveDepositarEDescontarATaxa(double taxa, double deposito, double valorEsperado){
            var conta = new ContaCorrente(1234, taxa);
            conta.Depositar(deposito);
            Assert.AreEqual(valorEsperado, conta.Saldo);
        }
        

        [Theory]
        [TestCase(15, 515, 515)]
        [TestCase(10, 500, 500)]
        [TestCase(5, 1000, 1000)]
        public void NaoDeveSacarContaNaoTemSaldoParaCobrirTaxa(double taxa, double saldo, double saque){
            var conta = new ContaCorrente(1234, taxa);
            conta.Saldo = saldo;
            Assert.AreEqual(0, conta.Sacar(saque));
        }        
    }
}