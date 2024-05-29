using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    // Exemplo de Classe Abstrata
    public abstract class Conta
    {
        protected decimal saldo;
        
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é {saldo.ToString("C")}.");
        }
    }
}