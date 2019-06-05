using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un algoritmo que imprima los números del 1 al 100. que calcule la suma 
            //de todos los números pares por un lado y otro la de todos los impares.

            int suma_pares = 0, suma_impares = 0;

            for (int i = 1; i <=100; i++)
            {
                if (i%2==0)
                {
                    suma_pares = suma_pares + i;
                }
                else
                {
                    suma_impares = suma_impares + i;
                }
            }
            Console.Write("El total de la suma de los pares es: " + suma_pares+"\n");
            Console.Write("El total de la suma de los impares es: " + suma_impares+"\n");
            Console.ReadLine();
        }
    }
}
