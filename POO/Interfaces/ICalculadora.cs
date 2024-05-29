using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Interfaces
{
    public interface ICalculadora
    {
        double Somar(int num1, int num2);
        double Subtrair(int num1, int num2);
        double Multiplicar(int num1, int num2);
        double Dividir(int num1, int num2);
    }
}