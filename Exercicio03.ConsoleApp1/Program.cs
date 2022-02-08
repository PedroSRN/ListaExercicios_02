using System;

namespace Exercicio03.ConsoleApp1
{
    internal class Program
    {
        /*•     O IMC – Índice de Massa Corporal é um critério da Organização Mundial 
                de Saúde para dar uma indicação sobre a condição de peso de uma pessoa 
                adulta
                • A fórmula é IMC = peso / (altura) ²
                • Elabore um algoritmo que leia o peso e a altura de um adulto e mostre 
                sua condição de acordo com a tabela abaixo.
                IMC em adultos Condição
                Abaixo de 18,5 Abaixo do peso
                Entre 18,5 e 25 Peso normal
                Entre 25 e 30 Acima do peso
                Acima de 30 obeso
*/
        static void Main(string[] args)
        {
            double peso, altura, resultado;
            Console.WriteLine("Digite seu peso:");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura");
            altura = Convert.ToDouble(Console.ReadLine());

           resultado = peso / (altura * altura);

            if(resultado < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if(resultado >= 18.5 && resultado <= 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (resultado > 25 && resultado <= 30)
            {
                Console.WriteLine("Acima peso");
            }
            else if(resultado > 30)
            {
                Console.WriteLine("Obeso");
            }

            Console.ReadLine();
                 
        }
    }
}
