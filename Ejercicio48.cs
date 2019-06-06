using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que solicite al usuario que ingrese vía teclado dos números enteros,
            //tome los dos numero de usuario, e imprima las suma, el producto, la diferencia,
            //el cociente y el restos de los dos números.
            int n1 = 0, n2 = 0, suma = 0, producto = 0, diferencia = 0;
            double cociente = 0;
            Console .Write("Ingrese el primer valor: ");
            n1 = Convert .ToInt32 (Console .ReadLine ());
            Console .Write("ingrese el primer valor: ");
            n2 = Convert .ToInt32(Console .ReadLine ());
            Console.WriteLine("======================RESULTADOS========================");
            suma = n1 + n2;
            Console .WriteLine("La suma de los dos numeros es: "+suma);
            producto = n1 * n2;
            Console.WriteLine("El productos  de los dos numeros es: "+producto);
            diferencia = n1 - n2;
            Console.WriteLine("La diferencia  de los dos numeros es: "+diferencia);
            cociente = (n1 / n2);
            Console.WriteLine("El cociente  delos dos numeros es: "+cociente);
            Console.ReadKey();

        }
    }
}
