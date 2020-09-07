using System;
using Questao4.Entidade;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### POO - Questão 4 ###");

            Televisao tv = new Televisao();
            Controle controle = new Controle(tv);

            controle.AumentarVolume();
            controle.AumentarVolume();
            controle.AumentarVolume();
            controle.AumentarVolume();
            controle.DiminuirVolume();

            
            controle.AumentarCanal();
            controle.AumentarCanal();
            controle.AumentarCanal();
            controle.DiminuirCanal();

            controle.MostrarDadosTV();
        }
    }
}
