using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que obtenga el producto de dos números enteros positivos mediante restas sucesivas
            int n1 = 0, n2 = 0, c = 0, multi = 0;
            Console .Write("Ingrese el primer número entero: ");
            n1 = Convert .ToInt32 (Console .ReadLine ());
            Console.Write("Ingrese el segundo número entero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            while (c < n2)
            {
                multi = multi - n1;
                c++;
            }
            Console .WriteLine("La multiplicación por sumas sucesivas es: "+multi*-1);
            Console.ReadKey();

        }
    }
}
