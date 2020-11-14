using System;

namespace Projeto_6_Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {   //Uma empresa decide dar aumento de 30% aos funcionários cujo salário é
            //inferior a 500 reais. Escreva um programa que receba o salário de um
            //funcionário e imprima o valor do salário reajustado ou uma mensagem
            //caso o funcionário não tenha direito a aumento.
            Console.WriteLine("DIGITE SEU SALÁRIO: ");
            int salario = int.Parse(Console.ReadLine());
             if(salario<500) {
                 double ajuste =  salario*1.30;
                Console.WriteLine("Você recebeu ajuste de 30% no seu salário e o valor a sacar é de: "+ajuste);
            } else {
                Console.WriteLine("Você não tem direito ao ajuste salarial!");
            }//fim do se
        }
    }
}
