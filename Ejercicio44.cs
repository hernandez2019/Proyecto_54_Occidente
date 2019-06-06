using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtener el cociente y el resto de dos números enteros positivos mediante resta sucesivas. 
            int n1 = 0, n2 = 1, c = 0, i = 0;
            while (n2 > n1)
            {
                Console.Write("Ingrese un valor entero positivo: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el otro valor menor al anterior: ");
                n2 = Convert.ToInt32(Console.ReadLine());
            }
            c = n1;
            while (c >= n2)
            {
                c = c - n2;
                i++;
            }
            Console.WriteLine("El cociente por restas sucesivas es: " + i);
            Console.WriteLine("El resto de la divisón por restas sucesivas es: " + c);
            Console.ReadKey();
        }
    }
}
