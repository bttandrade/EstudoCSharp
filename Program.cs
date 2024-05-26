using System.Globalization;
using Estudo.models;
using EstudoCSharp.models;

// Tipos de dados principais.
string apresentacao = "Olá, isso é uma string";
int quantidade = 10;
double altura = 1.80;
// Colocar um M no final do número decimal
decimal preco = 19.90M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);

Console.WriteLine("-----------------------------");
Console.WriteLine("Tipos de dados e conversão");

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
// ReadLine lê uma entrada em forma de string
int quantidadeEstoque = 10;
// Console.WriteLine("Digite a quantidade da compra: ");
// int quantidadeCompra = int.Parse(Console.ReadLine());
int quantidadeCompra = 2;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");

bool vendaPossivel = quantidadeEstoque > quantidadeCompra;
// Se for true
if (vendaPossivel)
{
    Console.WriteLine("Venda é possível");
}
// Outro if para ser testado
else if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
// Se for false
else
{
    Console.WriteLine("Venda não é possível");
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Condicionais switch");

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();
string letra = "a";

switch(letra)
{
    // Passa por cada caso
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        // Sai do caso sem ler os próximos
        break;
    default:
        Console.WriteLine("Consoante");
        break;
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Condicionais OR(||) - AND(&&) - NOT(!)");

int valor = 9;
// Precisa que os dois sejam verdadeiros
if (valor > 3 && valor < 8)
{
    Console.WriteLine("Valor dentre 4 a 7");
}
// Precisa que uma das condições seja verdadeira
else if (valor < 4 || valor > 7)
{
    Console.WriteLine("Valor abaixo de 4 ou acima de 7");
}
// Precisa que a condição seja oposta
if (!(valor % 2 == 0))
{
    Console.WriteLine("Valor nao e par");
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Operadores");

// Usando a classe Calculadora
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
// Loop com um contador fixo
for (int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} * {contador} = {numero * contador}");
}

Console.WriteLine("WHILE");

int numero1 = 5;
int contador1 = 1;
// Loop sem contador e que precisa de uma condição para encerrar
while (contador1 <= 10)
{
    Console.WriteLine($"{numero1} * {contador1} = {numero1 * contador1}");
    contador1++;
}

Console.WriteLine("DO WHILE");

int numero2 = 5;
int contador2 = 1;
// Loop que inicia um laço antes de ser testado e continua até uma condição ser atentida
do 
{
    Console.WriteLine($"{numero2} * {contador2} = {numero2 * contador2}");
    contador2++;
} while (contador2 <= 10);

Console.WriteLine("-----------------------------");
// Agrupamento de dados de mesmo tipo
Console.WriteLine("Array");

// Criar um array do tipo inteiro de tamanho 3
int[] arrayInteiros = new int[3];
// Adicionar valores ao array
arrayInteiros[0] = 13;
arrayInteiros[1] = 42;
arrayInteiros[2] = 27;

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posicao N{i} - {arrayInteiros[i]}");
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Array - Resize");

// Função para alterar o tamanho do array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
foreach (int valor2 in arrayInteiros)
{
    Console.WriteLine(valor2);
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Array - Copy");

int[] arrayInteiros2 = new int[arrayInteiros.Length];
// Função para copiar um array em outro com uma quantidade de dados copiados definida
Array.Copy(arrayInteiros, arrayInteiros2, arrayInteiros.Length);
foreach (int valor2 in arrayInteiros2)
{
    Console.WriteLine(valor2);
}


Console.WriteLine("-----------------------------");
Console.WriteLine("Lists");

List<string> listaString = new List<string>();
// Adicionar elementos
listaString.Add("BA");
listaString.Add("SP");
listaString.Add("RJ");
Console.WriteLine("Adicionando elementos a lista");

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posicao N{i} - {listaString[i]}");
}

// Remover elementos
listaString.Remove("SP");
Console.WriteLine("SP removido");

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posicao N{i} - {listaString[i]}");
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Propriedades, metodos e construtores");

// Instanciando objeto a partir da classe Pessoa
Pessoa p1 = new Pessoa();
p1.Nome = "Pedro";
p1.Sobrenome = "Almeida";
// Forma simplificada de instanciar
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

// Definir nova cultura como default
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
        
decimal dinheiro = 1582.40M;

// Alterar cultura localmente
Console.WriteLine(dinheiro.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
Console.WriteLine(dinheiro.ToString("C1", CultureInfo.CreateSpecificCulture("en-US")));

double porcentagem = .3412;
// Formatar como porcentagem
Console.WriteLine(porcentagem.ToString("P"));

double numero3 = 173412;
// Formatar em três duplas de números
Console.WriteLine(numero3.ToString("##-##-##"));

// Pega a data e hora local
// DateTime data = DateTime.Now;
DateTime data = DateTime.Parse("20/07/2024 18:00");

// Formatar data e hora
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

Console.WriteLine("-----------------------------");
// Tenta realizar um ação e trata possíveis exceções
Console.WriteLine("Exceções");

// Ler Arquivos
// string[] linhas = File.ReadAllLines("arquivos/leitura.txt");
// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }

// Tenta realizar algo e caso encontre uma exceção executa o catch
try
{
    string[] linhas = File.ReadAllLines("arquivos/leitura2.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
// Executa caso encontra a exceção definida
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
// Sempre executa o finally independente de exceções
finally 
{
    Console.WriteLine("Chegou ate aqui.");
}

// Cria e dispara exceções
// throw new Exception("Ocorreu uma excecao.");

Console.WriteLine("-----------------------------");

//Coleção que segue o padrão FIFO - Primeiro a entrar, primeiro a sair
Console.WriteLine("Coleções - Fila");

// Criar uma fila
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