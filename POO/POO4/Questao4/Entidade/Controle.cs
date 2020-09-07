using Questao4.Interfaces;

namespace Questao4.Entidade
{
    public class Controle :IControle
    {
        public Controle(Televisao televisao)
        {
            Televisao = televisao;
        }

        public Televisao Televisao { get; set; }

        public void AumentarVolume(){
            Televisao.Volume++;
        }

        public void DiminuirVolume(){
            Televisao.Volume--;
        }

        public void AumentarCanal(){
            Televisao.Canal++;
        }

        public void DiminuirCanal(){
            Televisao.Canal--;
        }
        
        public void MostrarDadosTV(){
            Televisao.MostrarDados();
        }

    }
}