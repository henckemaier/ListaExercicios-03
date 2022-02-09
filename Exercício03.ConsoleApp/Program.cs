using System;

namespace Exercício03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Algoritmo multiplos de 3====");
            Console.ReadLine();

            int soma = 0;

            Console.WriteLine("A soma dos multiplos de 3 de 1 a 500 são: ");
            Console.ReadLine();

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                    soma += i;
            }

            Console.WriteLine("A soma é: " + soma);

            Console.ReadKey();                               
        }
    }
}
