using NUnit.Framework;
using Questao4.Entidade;

namespace TesteNUnit
{
    public class ControleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeveCriarControle()
        {

            var televisao = new Televisao(0, 100, 0, 100);
            var controle = new Controle(televisao);
            Assert.NotNull(controle);
        }

        [Test]
        public void DeveAumentarVolume()
        {
            var televisao = new Televisao(0, 100, 0, 100);
            televisao.Volume = 5;

            var controle = new Controle(televisao);
            controle.AumentarVolume();

            Assert.AreEqual(6, controle.Televisao.Volume);
        }

        [Test]
        public void DeveDiminuirVolume()
        {
            var televisao = new Televisao();
            televisao.Volume = 5;

            var controle = new Controle(televisao);
            controle.DiminuirVolume();
            controle.DiminuirVolume();
            controle.DiminuirVolume();

            Assert.AreEqual(2, controle.Televisao.Volume);
        }

        [Test]
        public void DeveAumentarCanal()
        {
            var televisao = new Televisao();
            televisao.Canal = 10;

            var controle = new Controle(televisao);
            controle.AumentarCanal();
            controle.AumentarCanal();

            Assert.AreEqual(12, controle.Televisao.Canal);
        }

        [Test]
        public void DeveDiminuirCanal()
        {
            var televisao = new Televisao();
            televisao.Canal = 10;

            var controle = new Controle(televisao);
            controle.DiminuirCanal();
            controle.DiminuirCanal();
            controle.DiminuirCanal();
            controle.DiminuirCanal();

            Assert.AreEqual(6, controle.Televisao.Canal);
        }
    }
}