using System;

namespace Exercício02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Selecionador de números ímpares====");
            Console.ReadLine();


            for (int i = 100; i < 200; i++)
            {

                if (i % 2 == 1)
                {
                    Console.WriteLine("Número ímpar {0}", i);
                }

            }
            Console.Read();
        }
    }
}
