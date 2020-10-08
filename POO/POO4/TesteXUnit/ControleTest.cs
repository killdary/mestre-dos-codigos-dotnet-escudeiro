using Questao4.Entidade;
using Xunit;

namespace TesteXUnit
{
    public class ControleTest
    {
        [Fact]
        public void DeveCriarControle(){
            
            var televisao = new Televisao(0,100,0,100);
            var controle = new Controle(televisao);
            Assert.NotNull(controle);
        }

        [Fact]
        public void DeveAumentarVolume()
        {
            var televisao = new Televisao(0,100,0,100);
            televisao.Volume = 5;

            var controle = new Controle(televisao);
            controle.AumentarVolume();

            Assert.Equal(6, controle.Televisao.Volume);
        }

        [Fact]
        public void DeveDiminuirVolume()
        {
            var televisao = new Televisao(0,100,0,100);
            televisao.Volume = 5;

            var controle = new Controle(televisao);
            controle.DiminuirVolume();
            controle.DiminuirVolume();
            controle.DiminuirVolume();

            Assert.Equal(2, controle.Televisao.Volume);
        }

        [Fact]
        public void DeveAumentarCanal()
        {
            var televisao = new Televisao(0,100,0,100);
            televisao.Canal = 10;

            var controle = new Controle(televisao);
            controle.AumentarCanal();
            controle.AumentarCanal();

            Assert.Equal(12, controle.Televisao.Canal);
        }

        [Fact]
        public void DeveDiminuirCanal()
        {
            var televisao = new Televisao(0,100,0,100);
            televisao.Canal = 10;

            var controle = new Controle(televisao);
            controle.DiminuirCanal();
            controle.DiminuirCanal();
            controle.DiminuirCanal();
            controle.DiminuirCanal();

            Assert.Equal(6, controle.Televisao.Canal);
        }
    }
}