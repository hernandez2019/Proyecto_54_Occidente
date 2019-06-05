using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir, contar y sumar los múltiplos de 2 que hay entre una serie de número,
            //tal que el segundo sea mayor o igual que el primero
            int n1 = 1, n2 = 0, c = 0, cp = 0, sp = 0;
            while (n1 > n2)
            {
                Console.Write("Ingrese un valor entero positivo: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el otro valor mayor al anterior: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                if (n1 > n2)
                {
                    Console.Write("Error debe ingresar el Segundo valor mayor o igual al primero");
                }
            }
            c = n1;
            while (c <= n2)
            {
                if (c % 2 == 0)
                {
                    Console.WriteLine(c);
                    cp++;
                    sp = sp + c;
                }
                c++;
            }
            Console.WriteLine("Multiplos de 2 encontrados: " +cp);
            Console.WriteLine("La suma de los multiplos de 2: " +sp);
            Console.ReadKey();

        }
    }
}
