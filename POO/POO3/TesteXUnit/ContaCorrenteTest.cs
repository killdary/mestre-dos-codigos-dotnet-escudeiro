using Questao3.Entidades;
using Xunit;

namespace TesteXUnit
{
    public class ContaCorrenteTest
    {
        [Fact]
        public void DeveCriarUmaConta(){
            var conta = new ContaCorrente(1234, 10);
            Assert.NotNull(conta);
        }

        [Theory]
        [InlineData(15, 530, 500)]
        [InlineData(10, 500, 100)]
        [InlineData(5, 1010, 1000)]
        public void DeveSacarDinheiroCasoTenhaSaldoEDescontarATaxa(decimal taxa, decimal saldo, decimal saque){
            var conta = new ContaCorrente(1234, taxa);
            conta.Saldo = saldo;
            Assert.Equal(saque, conta.Sacar(saque));
        }

        [Theory]
        [InlineData(15, 515, 500)]
        [InlineData(10, 500, 490)]
        [InlineData(5, 1000, 995)]
        public void DeveDepositarEDescontarATaxa(decimal taxa, decimal deposito, decimal valorEsperado){
            var conta = new ContaCorrente(1234, taxa);
            conta.Depositar(deposito);
            Assert.Equal(valorEsperado, conta.Saldo);
        }
        

        [Theory]
        [InlineData(15, 515, 515)]
        [InlineData(10, 500, 500)]
        [InlineData(5, 1000, 1000)]
        public void NaoDeveSacarContaNaoTemSaldoParaCobrirTaxa(decimal taxa, decimal saldo, decimal saque){
            var conta = new ContaCorrente(1234, taxa);
            conta.Saldo = saldo;
            Assert.Equal(0, conta.Sacar(saque));
        }        
    }
}