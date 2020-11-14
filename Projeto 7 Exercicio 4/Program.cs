using System;

namespace Projeto_7_Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade Gustavo Borges: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade>=5 && idade <=7) {
                Console.WriteLine(" Você vai pra piscina infantil A com a Tia campeã Poliana Okimoto");
            } else {
                if(idade >=8 && idade <=10) {
                    Console.WriteLine("Você vai pra piscina infantil B com o Tio medalhista Fernando Sherer");
                } else {
                    if(idade >=11 && idade <= 13) {
                        Console.WriteLine("Você vai pra piscina Juvenil A com o professor Cesar Cielo medalha de bronze nos 100 metros");
                    } else {
                        if(idade >=14 && idade <= 17) {
                            Console.WriteLine("Você vai pra piscina Juvenil B com o professor Ricardo Prado Medalha de prata nos 400 metros");
                        } else {
                            Console.WriteLine("Você vai nadar com os Seniores e o professor Cesar Cielo medalha de ouro");
                        }
                    }
                }
            }
        }
    }
}
