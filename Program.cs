using Estudo.models;

// Tipos de dados principais.
string apresentacao = "Olá, isso é uma string";
int quantidade = 10;
double altura = 1.80;
decimal preco = 19.90M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);

// Forma I de instanciar a classe.
Pessoa p1 = new Pessoa();
p1.Nome = "Pedro";
p1.Idade = 20;
p1.Apresentar();

// Forma II de instanciar a classe.
Pessoa p2 = new Pessoa
{
    Nome = "Amanda",
    Idade = 19
};
p2.Apresentar();

// Forma III de instanciar a classe.
Pessoa p3 = new()
{
    Nome = "Tiago",
    Idade = 21
};
p3.Apresentar();