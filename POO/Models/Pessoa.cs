using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    // Exemplo de Abstração
    public class Pessoa 
    {
        // Construtor para exemplo
        public Pessoa()
        {
            
        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        
        // Abstraindo uma pessoa e trazendo seu nome e idade como atributos para a classe
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    } 
}