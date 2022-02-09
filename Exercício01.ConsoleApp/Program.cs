using System;
using System.Collections.Generic;

namespace Exercício01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] altura = new double[15];

            double maiorAltura = altura[0];
            double menorAltura = 1;

            Console.WriteLine("====Medidor de 1Altura====");
            Console.ReadLine();

            int i = 0;
            do
            {
                Console.Write("Digite sua altura: ");
                string strAltura = Console.ReadLine();
                altura[i] = Convert.ToDouble(strAltura);

                if (altura[i] <= menorAltura)
                    menorAltura = altura[i];

                if (altura[i] > maiorAltura)
                    maiorAltura = altura[i];

                i++;
            } while (i < 15);

            Console.WriteLine("A maior altura é: " + maiorAltura);
            Console.WriteLine("A menor altura é: " + menorAltura);
            Console.ReadLine();


        }
    }
}
