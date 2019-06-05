using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir y contar los números que son múltiplos de 2 y 3 que hay del 1 al 100.
            int cant = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                    cant = cant + 1;
                }
            }            Console.WriteLine("Multiplos de 2 y 3 encontrados: {0}", cant);            Console.ReadKey();
        }
    }
}
