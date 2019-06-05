using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un algoritmo que imprima las sumas de los primeros 100 números 
            int suma = 0;
            for (int i = 0; i <= 100; i++)
            {
                suma = suma + i;
            }
            Console.Write("El resultado de la suma de los primeros 100 números es: " + suma);
            Console.ReadLine();
        }
    }
}
