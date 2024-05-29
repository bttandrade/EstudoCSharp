using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    // Exemplo de Herança
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
        
        // Sobrescrevendo o método Apresentar() da classe Pessoa
        public override void Apresentar()
        {
            Console.WriteLine($"Me chamo {Nome} e ganho {Salario.ToString("C")} de salário.");
        }
        
        // Exemplo de método selado 
        // public sealed override void Apresentar()
        // {
        //     Console.WriteLine($"Me chamo {Nome} e ganho {Salario.ToString("C")} de salário.");
        // }
    }
}