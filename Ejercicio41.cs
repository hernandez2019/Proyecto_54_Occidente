using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introducir un número entero, imprimir el valor equivalente en binario
            int numero = 0, x = 0;
            Console.Write("Ingrese un numero ENTERO para Convertir a BINARIO: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n===============");
            Console.Write("BINARIO: ");
            while ((numero) != 0)
            {
                x = numero % 2;
                Console.Write("" + x);
                numero = numero / 2;
            }
            Console.ReadKey();
        }
    }
}
