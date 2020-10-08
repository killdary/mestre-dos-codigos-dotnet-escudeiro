using System;
using System.Collections.Generic;
using System.Linq;
using Questao4.Entidade;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Questao 4 ###");

            Console.WriteLine("Digite a quantidade de Alunos:");
            var qtdAlunos = Convert.ToInt32(Console.ReadLine());

            var alunos = new List<Aluno>();

            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine($"Digite o nome do Aluno {i+1}:");
                var nome = Console.ReadLine();

                Console.WriteLine($"Digite a nota do Aluno {i+1}:");
                var nota = Convert.ToDouble(Console.ReadLine());

                alunos.Add(new Aluno{
                    Nome = nome,
                    Nota = nota
                });                
            }

            var listaAlunosAcimaDe7 = alunos.Where( alunos=> alunos.Nota > 7).OrderBy(a => a.Nota).ToList();

            for (int i = 0; i < listaAlunosAcimaDe7.Count; i++)
            {
                Console.WriteLine($"O aluno {listaAlunosAcimaDe7[i].Nome} tem nota igual a {listaAlunosAcimaDe7[i].Nota}.");
            }
        }
    }
}
