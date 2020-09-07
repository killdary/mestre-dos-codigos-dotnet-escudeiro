using System;
using Questao1.Interfaces;

namespace Questao1.Entidades
{
    public class Questao1 : IQuestao1
    {
        IDisplay _display;
        public Questao1(IDisplay display)
        {
            _display = display;
        }

        public void Executar()
        { 
            System.Console.WriteLine("### Questão 1 ###");
            System.Console.WriteLine("Digite um valor para a variável A: ");
            var a = Convert.ToDecimal(Console.ReadLine());
            
            System.Console.WriteLine("Digite um valor para a variável B: ");
            var b = Convert.ToDecimal(Console.ReadLine());
            bool sair = false; 


            Menu();

            while (!sair)
            {
                System.Console.WriteLine("Digite uma opção:");
                
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        _display.Soma(a,b);
                        break;
                        
                    case 2:
                        _display.Subtracao(a,b);
                        break;
                        
                    case 3:
                        _display.Divisao(a,b);
                        break;
                        
                    case 4:
                        _display.Multiplicacao(a,b);
                        break;
                        
                    case 5:
                        _display.VerificarSeEPar(a,b);
                        break;

                    case 6:
                        System.Console.WriteLine("Digite um novo valor para a variável A: ");
                        a = Convert.ToDecimal(Console.ReadLine());
                        
                        System.Console.WriteLine("Digite um novo valor para a variável B: ");
                        b = Convert.ToDecimal(Console.ReadLine());
                        break;                        

                    case 7:
                        System.Console.Clear();
                        Menu();
                        break;
                        
                    default:
                        sair = true;
                        break;
                }

            }   
        }

        public void Menu()
        {
            System.Console.WriteLine("Digite uma das opções abaixo para realizar uma operação:");
            System.Console.WriteLine("-- Opção 1: Somar A e B;");
            System.Console.WriteLine("-- Opção 2: Subtrair  A e B;");
            System.Console.WriteLine("-- Opção 3: Dividir A e B;");
            System.Console.WriteLine("-- Opção 4: Multiplicar A e B;");
            System.Console.WriteLine("-- Opção 5: Imprimir A e B são pares ou impares;");
            System.Console.WriteLine("-- Opção 6: Trocar Valores de A e B;");
            System.Console.WriteLine("-- Opção 7: Limpar a tela;");
            System.Console.WriteLine("-- Opção Default: Digite um opção não listada acima para sair da aplicação");
        }
    }
}