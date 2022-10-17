using ExemploFundamentos.Models;
/* Usando a classe Pessoa

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Vitor";
pessoa1.Idade = 22;
pessoa1.Apresentar();

----------<<<<<>>>>>----------*/

/* Declaração de variáveis

string  apresentacao = "Olá, seja bem vindo!";
int quantidade = 1;
double altura = 1.86;
double AlturaComTratamentoDecimal = 1.80;
decimal preco = 99.99M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável altura com tratamento de decimais: " + AlturaComTratamentoDecimal.ToString("0.00"));
Console.WriteLine($"Valor da variável preco: {preco} ");
Console.WriteLine($"Valor da variável condicao: {condicao} ");

----------<<<<<>>>>>----------*/

/*Tipo de dado : Data

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
DateTime dataAtualAdicionandoDias = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtualAdicionandoDias);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

----------<<<<<>>>>>----------*/

/* Cast -- Casting
// usado para converter tipos de variaveis

int a = Convert.ToInt32("5");
int a1 = int.Parse("5"); // outra forma de conversão
Console.WriteLine(a);

// Conversão p string
//utiliza - se o método ToString

int inteiro = 50;
string a2 = inteiro.ToString();
Console.WriteLine(a2);

----------<<<<<>>>>>----------*/

/*Cast Impícito

int a = 5;
double b = a;
Console.WriteLine(b);
int a = 6;
long b = a;
----------<<<<<>>>>>----------*/

/* Operadores de Atribuição

int a = 10;
int b = 25;
int c = a + b;
Console.WriteLine(c);

c = c + 5; // 35 + 5
c += 5; //outra forma de usar uma atribuição de valor
Console.WriteLine(c);

----------<<<<<>>>>>----------*/

/* Operador Condicional --> IF Aninhado
// (Uso do Operador condicional p/ verificar se uma venda é possivel)

 int quantidadeEmEstoque = 3;
 int quantidadeCompra = 1;
 bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

 Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
 Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
 Console.WriteLine($"É possível realizar a venda?: {possivelVenda}");

 if (quantidadeCompra == 0)
 {
     Console.WriteLine("Venda inválida.");
 }
 else if (possivelVenda)
 {
    Console.WriteLine("Venda Realizada.");
 }
else
{
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
}
----------<<<<<>>>>>---------- */

/* Operador Condicional --> Switch case
// (Verificando se uma letra é vogal ou consoante, utilizando o Switch Case)

Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("A letra é uma vogal.");
        break;

    default:
        Console.WriteLine("A letra é uma consoante.");
        break;
}
----------<<<<<>>>>>---------- */

/* Operador OR (pipe, ||)
// se uma das verificações for verdadeira, o resultado retorna verdadeiro
// usando or p/ verificar se uma entrada em evento é liberada ou não 
// p/ entrar precisa ser maior de 18 anos ou ter autorização do responsavel

Console.WriteLine("Seja bem-vindo");
Console.WriteLine("Digite sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());
// Falta adicionar a verificação de autorização do responsavel 

bool maiorIdade = idade >= 18;
bool autorizacaoDoResponsavel = false;

if (maiorIdade || autorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada Liberada!");
}
else
{
    Console.WriteLine("Entrada não Permitida!");
}
----------<<<<<>>>>>---------- */

/* Operador AND (&&)
// se todas as verificações forem verdadeiras, o resultado retorna verdadeiro
//basta uma verif. falsa p/ que o resultado retorne false
// usando AND p/ um sistema de aprovação por nota/média e frequencia de presença
//p/ ser aprovado: nota >=7 e possuir presença minima

double frequenciaMinima =  60;
double mediaMinima = 7;
Console.WriteLine("Seja bem-vindo");

Console.WriteLine("Digite sua % de presença:");
double frequenciaAluno = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua média:");
double mediaAluno = Convert.ToDouble(Console.ReadLine());

bool frequencia = frequenciaAluno >= frequenciaMinima;
bool media = mediaAluno >= mediaMinima;

if (frequencia && media)
{
    Console.WriteLine("Você está aprovado!");
}
else
{
    Console.WriteLine("Você está reprovado");
}
----------<<<<<>>>>>---------- */

/*Realizando os calculos da classe Calculadora criada

Calculadora  calc = new Calculadora();


calc.Somar(3, 5);
calc.Subtrair(89, 55);
calc.Multiplicar(15, 6);
calc.Dividir(20, 2);
calc.Potencia(2, 2);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);

----------<<<<<>>>>>----------*/

/*Incremento e Decremento

int numero = 10;
int numero2 = 20;
Console.WriteLine(numero);
Console.WriteLine("Incrementando o número 10");
//numero = numero + 1; // outra alternativa da function abaixo
numero++; //incrementando em 1
Console.WriteLine(numero);

Console.WriteLine(numero2);
Console.WriteLine("decrementando o número 20");
numero2--;
Console.WriteLine(numero2);

----------<<<<<>>>>>----------*/

/* ESTRUTURA DE REPETIÇÃO -- > Uso do laço FOR
// Exemplo Tabuada de um numero

int numero = 6;

for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} * {contador} = {numero * contador}");
}

----------<<<<<>>>>>----------*/

/* ESTRUTURA DE REPETIÇÃO -- > Uso do laço WHILE

int numero = 5;
int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{contador + 1}° Execução : {numero} * {contador} = {numero * contador}");
    contador++;

    if(contador == 6) // interrompendo um fluxo de execução WHILE
    {
        break;
    }
}

----------<<<<<>>>>>----------*/

/* ESTRUTURA DE REPETIÇÃO -- > Uso do DO WHILE

int soma =0, numero = 0;

do
{
    Console.WriteLine($"Digite um número: (0 para parar!)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while(numero != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");

----------<<<<<>>>>>----------*/

// Construindo Menu interativo 

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("1 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

   opcao = Console.ReadLine();

   switch(opcao)
   {
        case "1":
            Console.WriteLine("Cadastro de Cliente.");
            break;
        case "2":
            Console.WriteLine("Busca de Cliente.");
            break;
        case "3":
            Console.WriteLine("Apagar Cliente.");
            break;
        case "4":
            Console.WriteLine("Encerrar.");
            exibirMenu = false;
            //Environment.Exit();
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
   }
}
