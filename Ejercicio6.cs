using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma_impar = 0;
            for (int i = 100; i >=1; i--)
            {

                if (i %2!=0)
                {
                    // Hacer un algoritmo que imprima los números impares desde el 100 hasta la unidad y calcule su suma
                    Console.Write(i + " ");
                    suma_impar = suma_impar + i;
                }

            }
            Console.Write("\nLa suma de los impares es: " + suma_impar);
            Console.ReadLine();
        }
    }
}
