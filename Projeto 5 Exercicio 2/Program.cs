using System;

namespace Projeto_5_Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano estamos: ");
            int anoatual = int.Parse(Console.ReadLine());

            Console.WriteLine("Em que ano você nasceu: ");
            int anonasc = int.Parse(Console.ReadLine());

            int idade = anoatual - anonasc;
            int semana =idade * 48;

            Console.WriteLine("Você possui " + idade + " anos de idade e já viveu " + semana + " semanas.");
        }
    }
}
