using System.Globalization;
using Estudo.models;
using EstudoCSharp.models;

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

// Console.WriteLine("Digite a quantidade em estoque: ");
// int quantidadeEstoque = int.Parse(Console.ReadLine());
// ReadLine le uma entrada em forma de string
int quantidadeEstoque = 10;
// Console.WriteLine("Digite a quantidade da compra: ");
// int quantidadeCompra = int.Parse(Console.ReadLine());
int quantidadeCompra = 2;

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

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();
string letra = "a";

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

Console.WriteLine("-----------------------------");
Console.WriteLine("Operadores");

Calculadora calc = new Calculadora();
calc.Somar(4, 5);
calc.Subtrair(5, 4);
calc.Multiplicar(5, 4);
calc.Dividir(7, 4);
calc.Potencia(2, 2);
calc.Seno(45);
calc.Coseno(45);
calc.Tangente(45);
calc.RaizQuadrada(9);

Console.WriteLine("-----------------------------");
Console.WriteLine("FOR");

int numero = 5;
for (int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} * {contador} = {numero * contador}");
}

Console.WriteLine("WHILE");
int numero1 = 5;
int contador1 = 1;
while (contador1 <= 10)
{
    Console.WriteLine($"{numero1} * {contador1} = {numero1 * contador1}");
    contador1++;
}

Console.WriteLine("DO WHILE");
int numero2 = 5;
int contador2 = 1;
do 
{
    Console.WriteLine($"{numero2} * {contador2} = {numero2 * contador2}");
    contador2++;
} while (contador2 <= 10);

Console.WriteLine("-----------------------------");
Console.WriteLine("Array");

int[] arrayInteiros = new int[3];
arrayInteiros[0] = 13;
arrayInteiros[1] = 42;
arrayInteiros[2] = 27;

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posicao N{i} - {arrayInteiros[i]}");
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Array - Resize");

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
foreach (int valor2 in arrayInteiros)
{
    Console.WriteLine(valor2);
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Array - Copy");

int[] arrayInteiros2 = new int[arrayInteiros.Length];
Array.Copy(arrayInteiros, arrayInteiros2, arrayInteiros.Length);
foreach (int valor2 in arrayInteiros2)
{
    Console.WriteLine(valor2);
}


Console.WriteLine("-----------------------------");
Console.WriteLine("Lists");

List<string> listaString = new List<string>();
listaString.Add("BA");
listaString.Add("SP");
listaString.Add("RJ");
Console.WriteLine("ADD");
for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posicao N{i} - {listaString[i]}");
}
listaString.Remove("SP");
Console.WriteLine("REMOVE");
for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posicao N{i} - {listaString[i]}");
}
Console.WriteLine("-----------------------------");
Console.WriteLine("Propriedades, metodos e construtores");
Pessoa p1 = new Pessoa();
p1.Nome = "Pedro";
p1.Sobrenome = "Almeida";
Pessoa p2 = new("Mateus", "Andrade");

Curso cursoDeIngles = new()
{
    Nome = "Ingles",
    Alunos = [],
};
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

Console.WriteLine("-----------------------------");
Console.WriteLine("Ajustando valores");

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
        
decimal dinheiro = 1582.40M;

Console.WriteLine(dinheiro.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
Console.WriteLine(dinheiro.ToString("C1", CultureInfo.CreateSpecificCulture("en-US")));

double porcentagem = .3412;

Console.WriteLine(porcentagem.ToString("P"));

double numero3 = 173412;

Console.WriteLine(numero3.ToString("##-##-##"));

// DateTime data = DateTime.Now;
DateTime data = DateTime.Parse("20/07/2024 18:00");

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

Console.WriteLine("-----------------------------");
Console.WriteLine("Excecoes");

// Ler Arquivos
// string[] linhas = File.ReadAllLines("arquivos/leitura.txt");
// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
try
{
    string[] linhas = File.ReadAllLines("arquivos/leitura2.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo nao encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Pasta nao encontrada. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma excecao generica. {ex.Message}");
}
finally 
{
    Console.WriteLine("Chegou ate aqui.");
    // throw new Exception("Ocorreu uma excecao.");
}

Console.WriteLine("-----------------------------");

//Coleção que segue o padrão FIFO - Primeiro a entrar, primeiro a sair
Console.WriteLine("Coleções - Fila");

// Criar um fila
Queue<int> fila = new();

// Adicionar elementos a fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

// Remover elementos da fila
Console.WriteLine($"Removendo o elemento no inicio: {fila.Dequeue()}");

fila.Enqueue(10);
foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------");

// Coleção que segue o padrão LIFO - Último a entrar, primeiro a sair
Console.WriteLine("Coleções - Pilha");

// Criar uma pilha
Stack<int> pilha = new();

// Adicionar elementos em uma pilha
pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

// Remover elementos de uma pilha
Console.WriteLine($"Removendo o elemento no topo: {pilha.Pop()}");

pilha.Push(10);
foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------");

// Coleção de chave-valor que armazena valores sem ordem específica
Console.WriteLine("Coleções - Dictionary");

// Criar um dictionary
Dictionary<string, string> estados = []; // Nova forma
// Dictionary<string, string> estados = new() - Forma padrão;

// Adicionar elementos ao dictionary
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("RJ", "Rio de Janeiro");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} / Valor: {item.Value}");
}
Console.WriteLine("Removendo SP e alterando BA");

// Remover um elemento pela chave
estados.Remove("SP");
// Alterar um elemento, mantendo a chave
estados["BA"] = "Bahia - Valor Alterado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} / Valor: {item.Value}");
}

// Verificar se a chave existe
string chave = "BA";

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Chave existe e tem como valor: {estados[chave]}");
}
else 
{
    Console.WriteLine($"Chave não existe");
}

Console.WriteLine("-----------------------------");

// Método para agrupar vários elementos de diferentes tipos de dados
Console.WriteLine("Tuplas");

(int id, string nome, string sobrenome, decimal altura) tupla = (1, "Pedro", "Almeida", 1.79M);
// ValueTuple<int, string, string, decimal> tupla = (1, "Pedro", "Almeida", 1.79M);
// var tupla = Tuple.Create(1, "Pedro", "Almeida", 1.79M);

Console.WriteLine($"ID: {tupla.id}");
Console.WriteLine($"Nome: {tupla.nome}");
Console.WriteLine($"Sobrenome: {tupla.sobrenome}");
Console.WriteLine($"Altura: {tupla.altura}");

LeituraArquivo arquivo = new();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/leitura.txt");
// Desmarcar a necessidade de uma variável na tupla
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/leitura.txt");

if (sucesso)
{
    Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
    foreach (string linhas in linhasArquivo)
    {
        Console.WriteLine(linhas);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}

Console.WriteLine("-----------------------------");

// Descontruir um objeto separando suas partes em variáveis
Console.WriteLine("Desconstrução de objetos");

Pessoa p3 = new("Amanda", "Santana");

// Desconstruir o objeto
(string nome, string sobrenome) = p3;

Console.WriteLine($"{nome} {sobrenome}");

Console.WriteLine("-----------------------------");

// Normalmente usado quando há um único if-else
Console.WriteLine("Operador ternário");

int valor3 = 9;
bool par = valor3 % 2 == 0;

Console.WriteLine($"O número {valor3} é " + (par ? "par" : "ímpar"));