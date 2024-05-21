using Estudo.models;

// Tipos de dados principais.
string apresentacao = "Ola, isso e uma string";
int quantidade = 10;
double altura = 1.80;
decimal preco = 19.90M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variavel quantidade: " + quantidade);
Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variavel preco: " + preco);
Console.WriteLine("Valor da variavel condicao: " + condicao);

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

Console.WriteLine("-----------------------------");
Console.WriteLine("Tipos de dados e Conversoes");

int a = Convert.ToInt32("5");
Console.WriteLine (a);
// Pode ser nulo
int b = int.Parse("5");
Console.WriteLine (b);
// Não pode ser nulo
string c = a.ToString();
// Converter para string
Console.WriteLine(c + b);
// Tentar converter
Console.WriteLine(int.TryParse("15", out a));

Console.WriteLine("-----------------------------");
Console.WriteLine("Condicionais if - else if - else");

Console.WriteLine("Digite a quantidade em estoque: ");
int quantidadeEstoque = int.Parse(Console.ReadLine());
// ReadLine le uma entrada em forma de string
Console.WriteLine("Digite a quantidade da compra: ");
int quantidadeCompra = int.Parse(Console.ReadLine());

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");

bool vendaPossivel = quantidadeEstoque > quantidadeCompra;
if (vendaPossivel)
{
    Console.WriteLine("Venda e possivel");
} 
else if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda invalida");
}
else
{
    Console.WriteLine("Venda nao e possivel");
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Condicionais switch");

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch(letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Consoante");
        break;
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Condicionais OR(||) - AND(&&) - NOT(!)");

int valor = 9;

if (valor > 3 && valor < 8)
{
    Console.WriteLine("Valor dentre 4 a 7");
} else if (valor < 4 || valor > 7)
{
    Console.WriteLine("Valor abaixo de 4 ou acima de 7");
}
if (!(valor % 2 == 0))
{
    Console.WriteLine("Valor nao e par");
}