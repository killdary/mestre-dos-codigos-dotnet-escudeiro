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
            Televisao.AumentarVolume();
        }

        public void DiminuirVolume(){
            Televisao.DiminuirVolume();
        }

        public void AumentarCanal(){
            Televisao.AumentarCanal();
        }

        public void DiminuirCanal(){
            Televisao.DiminuirCanal();
        }
        
        public void MostrarDadosTV(){
            Televisao.MostrarDados();
        }

    }
}