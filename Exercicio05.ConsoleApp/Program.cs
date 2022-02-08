using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        /*Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem 
        iguais deverá se somar os dois, caso contrário multiplique A por B.
        Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma 
        variável C e mostrar seu conteúdo na tela*/
        static void Main(string[] args)

        {
            int v1, v2, resultado;
            Console.WriteLine("Digite o primeiro valor: ");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            if(v1 == v2)
            {
                resultado = v1 + v2; 
                Console.WriteLine("somou " + resultado);
            }
            else if(v1 != v2)
            {
                resultado = v1 * v2;
                Console.WriteLine("Multiplicou " + resultado);
            }

            Console.ReadLine();
        }
    }
}
