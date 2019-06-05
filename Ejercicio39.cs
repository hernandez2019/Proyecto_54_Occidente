using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un algoritmo que imprima los primeros 30 términos de la serie de Fibonacci.
            //La serie es: 0, 1, 2, 3, 5, 8,…….
            int N = 30;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine (i + " - " +serieFib(i));
            }
            Console.ReadKey();    

        }
        public static long serieFib(int n)
        {
            if (n <= 1)
                return n;

            else return serieFib(n - 1) + serieFib(n - 2);
        }

    }
}
