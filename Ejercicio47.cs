using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un algoritmo que calcule independientemente las sumas de impares de los números entre el 1 y el 1000.
            int sumaimp = 0;
            for (int i = 1; i <=1000; i++)
            {
                if (i % 2 != 0)
                {
                    sumaimp = sumaimp + i;                   
                }
               
            }
            Console .WriteLine ("La suma de los impares es: {0}",sumaimp);
            Console.ReadKey();

        }
    }
}
