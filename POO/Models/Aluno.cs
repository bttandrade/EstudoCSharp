using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    // Exemplo de Herança
    public class Aluno : Pessoa
    {
        // Construtor por herança
        public Aluno()
        {
            
        }
        public Aluno(string nome) : base(nome)
        {
            
        }
        
        public double Nota { get; set; }
        
        // Sobrescrevendo o método Apresentar() da classe Pessoa
        public override void Apresentar()
        {
            Console.WriteLine($"Me chamo {Nome} e sou um aluno nota {Nota}.");
        }
    }
}