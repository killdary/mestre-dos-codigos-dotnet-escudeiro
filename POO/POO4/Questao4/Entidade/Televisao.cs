using System;

namespace Questao4.Entidade
{
    public class Televisao
    {
        public int Volume { get; set; }
        public int Canal { get; set; }

        public void MostrarDados()
        {
            System.Console.WriteLine($"TV Db1 - {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}");
            System.Console.WriteLine($"Canal: {Canal}");
            System.Console.WriteLine($"Volume: {Volume}");

        }
    }
}