using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un algoritmo que imprima y cuente los multiplos de 3 que hay entre 1 y 100
            for (int i = 1; i <=100 ; i++)
            {
                if (i%3==0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
