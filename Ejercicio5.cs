using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un algoritmo que imprima los números impares hasta el 100 y que imprima cuantos impares hay
            int cnt = 0;
            for(int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    cnt = cnt + 1;
                }
            }
            Console.Write("\nHay " + cnt + " impares");
            Console.ReadLine();
        }
    }
}
