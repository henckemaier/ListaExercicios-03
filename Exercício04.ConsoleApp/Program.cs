using System;

namespace Exercício04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número da tabuada que queira: ");
            string strValor = Console.ReadLine();
            int valor = Convert.ToInt32(strValor);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", i, valor, i * valor);
                Console.ReadLine();
            }
        }
    }
}
