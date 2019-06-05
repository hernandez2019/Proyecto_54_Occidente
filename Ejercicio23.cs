using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir dos números por teclado.Imprimir los números naturales que hay entre ambos números empezando
            //por el más pequeño, contar cuantos hay y cuantos de ellos son pares. Calcular la suma de los impares.
            int num1, num2, cantNurales, cantpares, sumImpares;
            cantNurales = 0;
            cantpares = 0;
            sumImpares = 0;
            Console.Write("Ingrese un de Inicio: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un de Inicio: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = num1; i <=num2; i++)
            {
                Console.WriteLine(i);
                cantNurales = cantNurales + 1;
                if (i%2==0)
                {
                    cantpares = cantpares + 1;
                }
                else
                {
                    sumImpares = sumImpares + i;
                }
            }
            Console.WriteLine("Cantidad de numeros Naturales: {0}", cantNurales);
            Console.WriteLine("Cantidad Numero Pares: {0}", cantpares);
            Console.WriteLine("Suma de Numeros Impares: {0}", sumImpares);
            Console.ReadKey();
        }
    }
}
