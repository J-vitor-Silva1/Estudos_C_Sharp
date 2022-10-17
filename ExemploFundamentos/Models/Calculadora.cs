using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y) // metodo soma da classe calculadora
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y) // metodo sub da classe calculadora
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Dividir(int x, int y) // metodo div da classe calculadora
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Multiplicar(int x, int y) // metodo mult da classe calculadora
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Potencia(int x, int y) // metodo para realizar potenciação
        {
            double pot = Math.Pow(x, y); // a classe Math é respónsavel por executar op + complexas
            Console.WriteLine($"{x}^{y} = {pot} ");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180; // calculo p/ conversão do angulo para radiando
            double seno = Math.Sin(radiano); // chamando o metodo Seno(Sin)
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 6)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 6)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 6)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}