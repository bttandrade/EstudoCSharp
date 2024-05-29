using System.Globalization;
using POO.Models;
using POO.Interfaces;

// POO com C#
// POO é um paradigma de programação, ou seja, corresponde a uma técnica de programação para um fim específico. Possui 4 pilares: Abstração, Encapsulamento, Herança e Polimorfismo.

// Abstração - Abstrai um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.
// Encapsulamento - Serve para proteger uma classe e definir limites para alteração de suas propriedades.
// Herança - Permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes.
// Polimorfismo - Permite sobrescrever métodos de outras classes para que se comportem de maneira diferente e tenham implementação própria.

Console.WriteLine("---Exemplo Abstração---");
Pessoa p1 = new();
p1.Nome = "Pedro";
p1.Idade = 18;
p1.Apresentar();

Console.WriteLine("---Exemplo Encapsulamento---");
ContaCorrente c1 = new(173, 1000.90M);
c1.ExibirSaldo();
c1.Sacar(90);
c1.ExibirSaldo();

Console.WriteLine("---Exemplo Herança---");
Aluno a1 = new("Tiago");
Console.WriteLine("Nome do aluno: " + a1.Nome);
a1.Nota = 9.5;
Professor prof = new();
prof.Nome = "Amanda";
Console.WriteLine("Nome da professora: " + prof.Nome);
prof.Salario = 3000.00M;

Console.WriteLine("---Exemplo Polimorfismo---");
a1.Apresentar();
prof.Apresentar();

// Classe Abstrata - Tem como objetivo ser exclusivamente um modelo para ser herdado, portanto não pode ser instanciada.

Console.WriteLine("---Exemplo Classe Abstrata---");
Corrente cor = new();
cor.Creditar(500M);
cor.ExibirSaldo();

// Classe Selada - Impede que outras classes façam herança dela, ou seja, nenhuma classe pode ser sua derivada (sealed). Também existem métodos e propriedades seladas.
// Exemplo na classe Professor

// Interface - É um contrato que pode ser implementado por uma classe.

Console.WriteLine("---Exemplo Interface---");
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));