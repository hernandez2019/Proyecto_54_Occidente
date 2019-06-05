using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir tantos números que hay entre el 1 al 100.excepto los múltiplos de 2.
            int numero = 0;
            for (int i = 1; i < 15; i++)
            {
                Console.Write("Ingrese un numero entre el 1 al 100, excepto los Multiplos de 2:");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero<0 || numero >100)
                {
                    Console.WriteLine("El numero ingresado no esta entre el rango de 1 - 100");
                    Console.ReadKey();
                    return;
                }
                if (numero %2==0)
                {
                    Console.WriteLine("El numero ingresado es multiplo de dos");
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}
