using Questao3.Entidades;
using Xunit;

namespace TesteXUnit
{
    public class ContaEspecialTest
    {
        [Fact]
        public void DeveCriarUmaConta(){
            var conta = new ContaEspecial(1234, 1000);
            Assert.NotNull(conta);
        }

        [Theory]
        [InlineData(1000, 530, 600)]
        [InlineData(1000, 500, 700)]
        [InlineData(1000, 1010, 1500)]
        public void DeveSacarDinheiroCasoTenhaSaldoEDescontarATaxa(decimal limite, decimal saldo, decimal saque){
            var conta = new ContaEspecial(1234, limite);
            conta.Saldo = saldo;
            Assert.Equal(saque, conta.Sacar(saque));
        }

        [Theory]
        [InlineData(1000, -350, 500, 150)]
        [InlineData(650, 100, 490, 590)]
        [InlineData(100, 1000,  995, 1995)]
        public void DeveDepositar(decimal limite, decimal saldo, decimal deposito, decimal valorEsperado){
            var conta = new ContaEspecial(1234, limite);
            conta.Saldo = saldo;
            conta.Depositar(deposito);
            Assert.Equal(valorEsperado, conta.Saldo);
        }
        

        [Theory]
        [InlineData(1000, -350,  5150, 0)]
        [InlineData(650,  100,  5000, 0)]
        [InlineData(100,  1000, 10000, 0)]
        public void NaoDeveSacarContaNaoTemSaldoMesmoComLimite(decimal limite, decimal saldo, decimal saque, decimal valorEsperado){
            var conta = new ContaEspecial(1234, limite);
            conta.Saldo = saldo;
            Assert.Equal(valorEsperado, conta.Sacar(saque));
        }        
    }
}