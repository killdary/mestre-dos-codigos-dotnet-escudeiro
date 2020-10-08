using System;

namespace Questao4.Entidade
{
    public class Televisao
    {
        private int VolumeMinimo { get; set; }
        private int VolumeMaximo { get; set; }
        private int CanalMinimo { get; set; }
        private int CanalMaximo { get; set; }
        public int Volume { get; private set; }
        public int Canal { get; private set; }

        public Televisao(int volumeMinimo, int volumeMaximo, int canalMinimo, int canalMaximo)
        {
            VolumeMinimo = volumeMinimo;
            VolumeMaximo = volumeMaximo;
            CanalMinimo = canalMinimo;
            CanalMaximo = canalMaximo;
            Canal = canalMinimo;
            Volume = volumeMinimo;
        }

        public void MostrarDados()
        {
            System.Console.WriteLine($"TV Db1 - {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}");
            System.Console.WriteLine($"Canal: {Canal}");
            System.Console.WriteLine($"Volume: {Volume}");
        }

        public void AumentarVolume()
        {
            Volume = (Volume == VolumeMaximo) ? VolumeMaximo : Volume++;
        }

        public void DiminuirVolume()
        {
            Volume = (Volume == VolumeMinimo) ? VolumeMinimo : Volume--;
        }

        public void AumentarCanal()
        {
            Canal = (Canal == CanalMaximo) ? CanalMaximo : Canal++;
        }

        public void DiminuirCanal()
        {
            Canal = (Canal == CanalMinimo) ? CanalMinimo : Canal--;
        }
    }
}