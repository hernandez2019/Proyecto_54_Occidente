using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un algoritmo que imprima y cuente los multiplos de 5 que hay entre 1 y 500
            int cnt = 0;
            for (int i = 1; i <= 500; i++)
            {
                if (i%5==0)
                {
                    Console.Write(i + " ");
                    cnt++;
                }
            }
            Console.Write("\n Hay " + cnt + " multiplos de 5");
            Console.ReadLine();
        }
    }
}
