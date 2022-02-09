using System;

namespace Exercício05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("====Sequenciador de valores====");
            Console.ReadLine();

            Console.Write("Digite o para iniciar a sequência: ");
            string Valor = Console.ReadLine();

            int valor = Convert.ToInt32(Valor);

            int fatorial = 1;

            /////////

            Console.Write(valor + "! = ");

            //////////

            for (int i = valor; i > 0; i--)
            {
                if (i != 1)
                    Console.Write(i + " x ");
                else
                    Console.Write(i);

                fatorial = fatorial * i;
            }

            /////////

            Console.Write(" = " + fatorial);

            Console.ReadKey();
        }
    }
}
