using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un algoritmo que calcule la suma de los números impares conprendidos entre el 0 y el 100
            int suma_impar = 0;
            for (int i = 0; i <=100 ; i++)
            {
                if (i%3==0)
                {
                    suma_impar = suma_impar + i;
                }
            }
            Console.Write("La suma de los impares es: " + suma_impar);
            Console.ReadLine();
        }
    }
}
