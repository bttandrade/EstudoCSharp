using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO.Interfaces;

namespace POO.Models
{
    public class Calculadora : ICalculadora
    {
        public double Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public double Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
        public double Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        public double Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}