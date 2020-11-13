using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;
            int menos = num1 - num2;
            int vezes = num1 * num2;
            int divide = num1 / num2;

            Console.WriteLine("O resultado da soma é:" + soma);
            Console.WriteLine("A subtração é: "+ menos);
            Console.WriteLine("A Multiplicação é:"+ vezes);
            Console.WriteLine("A divisão é: "+ divide);

        }
    }
}
