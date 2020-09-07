using System;
using Questao2.Entidades;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### POO - Questão 2");
            var pessoa = new Pessoa("Fulano de Tal", new DateTime(1990, 05, 01), 1.9);

            System.Console.WriteLine(pessoa.ToString());
        }
    }
}
