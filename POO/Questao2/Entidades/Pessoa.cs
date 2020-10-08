using System;

namespace Questao2.Entidades
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public double Altura { get; private set; }

        public Pessoa(string nome, DateTime dataNascimento, double altura)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }

        public int CalcularIdade(){
            var hoje = DateTime.Now;
            var idade = hoje.Year - DataNascimento.Year;
            return hoje.DayOfYear < DataNascimento.DayOfYear ? idade -1 : idade;
        }

        public override string ToString(){
            return @"Pessoa: \n"+
                    " -Nome: "+ Nome +"\n"+
                    " -Data de Nascimento: "+ DataNascimento.ToString("dd/MM/yyyy") +"\n"+
                    " -Idade: "+ CalcularIdade() +"\n"+
                    " -Altura: "+ Altura +"\n";
        }

        
    }
}