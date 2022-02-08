using System;
namespace exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo que leia três valores inteiros e diferentes e
              mostre-os em ordem decrescente*/

            int val1, val2, val3;
              
            Console.Write("Digite o primeiro valor: ");
            val1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            val2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            val3 = Convert.ToInt32(Console.ReadLine());


            if (val1 >= val2 && val1 >= val3 && val2 >= val3)
                Console.WriteLine("a ordem decrescente é: " + val1 + "," + val2 + "," + val3);

            else if (val1 >= val2 && val1 >= val3 && val3 >= val2)
                Console.WriteLine("a ordem decrescente é: " + val1 + "," + val3 + "," + val2);

            else if (val2 >= val1 && val2 >= val3 && val1 >= val3)
                Console.WriteLine("a ordem decrescente é: " + val2 + "," + val1 + "," + val3);

            else if (val2 >= val1 && val2 >= val3 && val3 >= val2)
                Console.WriteLine("a ordem decrescente é: " + val2 + "," + val3 + "," + val1);

            else if (val3 >= val1 && val3 >= val2 && val1 >= val2)
                Console.WriteLine("a ordem decrescente é: " + val3 + "," + val1 + "," + val2);

            else if (val3 >= val1 && val3 >= val2 && val2 >= val1)
                Console.WriteLine("a ordem decrescente é: " + val3 + "," + val2 + "," + val1);


            Console.ReadLine();




        }
    }
}
