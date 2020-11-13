using System;

namespace Projeto_4_Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            int dias = meses * 360;
            int horas = dias * 24;
            int minutos = horas * 60;

            Console.WriteLine("Você já viveu: " + meses + " meses, "+ dias + " dias, " + horas + " horas,  " + minutos + " minutos.");
        }
    }
}
