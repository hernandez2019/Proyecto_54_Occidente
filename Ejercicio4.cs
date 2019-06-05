using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un algoritmo que imprima los números pares entrel el 0 al 100
            for (int i = 0; i <= 100; i++)
            {
                if (i%2==0){
                    Console.Write(i +" ");
                }
            }
            Console.ReadLine();
        }
    }
}
