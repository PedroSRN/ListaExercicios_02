using System;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        /*Exercício 4:
        • Faça um algoritmo para receber um número qualquer e informar na tela se 
        é par ou ímpar*/
 
        {
            int numero, calculo;
            Console.WriteLine("Digite um número que deseja verificar: ");
            numero = Convert.ToInt32(Console.ReadLine());


            if(numero % 2 == 0) 
            {
                Console.WriteLine("É par ");
            }
            else 
            {
                Console.WriteLine("É impar");
            }
            
            Console.ReadLine();
        }
    }
}
