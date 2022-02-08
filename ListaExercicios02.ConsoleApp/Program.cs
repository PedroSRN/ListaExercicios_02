using System;

namespace ListaExercicios02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        /*Exercício 1:
                • Faça um algoritmo que leia os valores A, B, C e imprima na tela se a 
                soma de A + B é menor que C.*/
        
        {
            int val1, val2, val3;

            Console.WriteLine("Digite o Primeiro valor: ");
            val1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor: ");
            val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Terceiro valor: ");
            val3 = Convert.ToInt32(Console.ReadLine());

            if (val1 + val2 < val3)
                Console.WriteLine("A Soma dos Valores 1 e 2 é menor que o valor 3");

            else if (val1 + val2 == val3)
                Console.WriteLine("A soma dos Valores 1 e 2 é igual ao valor 3");

            else Console.WriteLine("A Soma dos Valores 1 e 2 é maior que O valor 3 ");

            Console.ReadLine();
        }
    }
}
