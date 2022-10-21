using ExemploFundamentos.Common.Models;

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

/* Construindo Menu interativo 

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

----------<<<<<>>>>>----------*/

/* Implementando um Array de Inteiros

Console.WriteLine("Percorrendo o Array com FOR");
int[] arrayInteiros = new int[3]; // Declarando array de 3 indices/valores do tipo inteiro
arrayInteiros[0] = 72; //Indices da array
arrayInteiros[1] = 64; //Indices da array
arrayInteiros[2] = 50; //Indices da array

for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("Percorrendo o Array com FOREACH");

// Nesta forma irá exibir somente os valores da array
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }

// Desta forma aqui, Exibira a posição do indice atribuido do valor
int contadorForeach = 0; // declarando um contador para exibir o indice
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
    contadorForeach++; // incrementando o contador
}
----------<<<<<>>>>>----------*/

/* Redimensionando um Array

Console.WriteLine("Percorrendo o Array com FOR");
int[] arrayInteiros = new int[3]; // Declarando array de 3 indices/valores do tipo inteiro
arrayInteiros[0] = 72; //Indices da array
arrayInteiros[1] = 64; //Indices da array
arrayInteiros[2] = 50; //Indices da array

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2]; // Criando um novo array com tamanho dobrado(redimensionado) do anterior, para que possamos copialo com uma capacidade maior
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length); // copiando o array antigo e jogando todos os indices no novo array criado

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
// O Array.Resize é usado p/ redimensionar um array


for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}
----------<<<<<>>>>>----------*/

/* Trabalhando com Listas


List<string> listaString = new List<string>(); // Sintaxe p/ criar LISTAS

listaString.Add("ES");
listaString.Add("MG");
listaString.Add("RJ");
listaString.Add("SP");

Console.WriteLine("Percorrendo a lista com o FOR");
for( int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista com o FOREACH");
int contadorForeach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição N° {contadorForeach} - {item}");
    contadorForeach++;
}
----------<<<<<>>>>>----------*/

/*Desafios de Código Básico C# - Pottencial

1/3 - Subtraindo o Produto e a soma de um número inteiro

Desafio
Dado um número inteiro ( n ) , retorne a diferença entre
o produto de seus dígitos e a soma de seus dígitos.

Entrada
A entrada consiste em um número inteiro ( n );

Saída
A saída consiste na multiplicação do produto dos dígitos ( n ),
a soma de seus dígitos e a diferenção entre o produto e a soma, como no exemplo abaixo:

Ex: Entrada:234 -- Saída:15

Explicação: 

Produto de dígitos = 2 * 3 * 4 = 24

Soma dos dígitos = 2 + 3 + 4 = 9

Resultado = 24 - 9 = 15

Código Inicial -->

using System;

class DIO {
        
static void Main(string[] args){

        int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
        while (n > 0){
             int l = n % 10;
// TODO: Crie as outras condições necessárias para a resolução do desafio:
             p *= l;
             s +=      ;
             n /=      ;
           }

           Console.WriteLine(p-s);
        }
    }
----------<<<<<>>>>>----------*/

/* Código do desafio 1

class  Program
{
static void Main(string[] args)
    {
        Console.WriteLine("Informe um número inteiro: ");
        int numero = int.Parse(Console.ReadLine()); // (N)
        int produto = 1;
        int soma = 0;
        while (numero > 0)
            {
              int l = numero % 10; // Definindo a variavel "l" e atribuindo "n" a ela para que
                                  // possa separar o ultimo digito

              produto *= l;
              soma += l;
              numero /= 10;
            }
        Console.WriteLine($"Valor do produto = {produto}");
        Console.WriteLine($"Valor da soma = {soma}");
        Console.WriteLine($"Resultado da diferença do produto pela soma = {produto - soma} ");
    }
 }
 ----------<<<<<>>>>>----------*/

/*Desafios de Código Básico C# - Pottencial

1/2 - Encaixa ou Não?

Desafio
Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.

Entrada
A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.

Saída
Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo.

Exemplo de Entrada	                        Exemplo de Saída

4                                           encaixa
56234523485723854755454545478690 78690      nao encaixa
5434554 543                                 encaixa
1243 1243                                   nao encaixa
54 64545454545454545454545454545454554

Código Inicial -->

using System.IO;
using System.Linq;

class {

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (                 )
        {
            
            string a = v[0];
            string b = v[1];

            if (                  )
                Console.WriteLine("nao encaixa");
            else if (                                )
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }

    }

}
----------<<<<<>>>>>----------*/

/* Código do desafio 2


using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
class DIO
{

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        List<string> v = new List<string>();
        for (  int i = 0; i < qt; i++ )
        {
            v.AddRange(Console.ReadLine().Split(" "));
            
            string a = v[0];
            string b = v[1];

            if ( a.Length < b.Length )
            {
              Console.WriteLine("nao encaixa");
            }
            else if ( a.Length >= b.Length && a.EndsWith(b))
            {
              Console.WriteLine("encaixa");
            }
            else
            {
              Console.WriteLine("nao encaixa");
            }

            v.Clear();
        }

    }

}
----------<<<<<>>>>>----------*/

/*Desafios de Código Básico C# - Pottencial

3 / 3 - Três Divisores

Desafio
Dado um inteiro n, retorne true se n tiver exatamente três divisores positivos.
Caso contrário, retorne false. O inteiro m é um divisor de n, se existe um inteiro k tal que n = k * m. 

Entrada
O arquivo de entrada consiste em um inteiro n que será validada caso esteja sob as condições do desafio.

Saída
A saída consistirá em um tipo booleano: true ou false. Como nos exemplos a baixo:

Exemplo 1:

Entrada	            Saída

2	                false

Explicação: 2 possui apenas dois divisores: 1 e 2.

Exemplo 2:

Entrada	            Saída
4	                true

Explicação: 4 tem três divisores: 1, 2 e 4.

Código Inicial -->

using System;
 
class Solution {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
 
        for (int i = 1; i <= n; i++) {
// TODO: Crie as outras condições necessárias para a resolução do desafio:
            if (n % i ==     ) {
                count++;
            }
            if (count >      ) {
                Console.WriteLine(false);
            }
        }
         Console.WriteLine(count == 3);
    }
}

----------<<<<<>>>>>----------*/

/* Código do Desafio 3

using System;

public static class Solution
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count == 3);
    }
}
----------<<<<<>>>>>----------*/
