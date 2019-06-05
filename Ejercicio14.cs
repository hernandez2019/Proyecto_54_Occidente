using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular la suma de los cuadrados de los números pares entre el 0 y el 100
            double suma,total=0;
            for (int i = 0; i <= 100; i++)
            {
                if (i%2==0)
                {
                  suma = Math.Pow(i, 2);
                  total = total + suma;
                    Console.Write(i+" ");
                }
            }
            Console.Write("\nEl total de la suma en potencias es: " + total);
            Console.ReadLine();
        }
    }
}
