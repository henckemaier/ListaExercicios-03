using System;

namespace Exercício02.Console.App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");
            Console.ReadLine();
            for (int i = 100; i < 200; i++)
            {
                if (i == 105)
                {
                    break;
                }

                Console.WriteLine("Value of i: {0}", i);
            }
        }
    }
}
