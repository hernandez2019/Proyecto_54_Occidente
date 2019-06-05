using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir un número por teclado que nos diga si es positivo o negativo
            int numero;
            Console.Write("Ingrese número: ");
            numero = int.Parse(Console.ReadLine());
            if (numero >=0)
            {
                Console.Write("El número " + numero + " es positivo");
            }
            else
            {
                Console.Write("El número " + numero + " es negativo");
            }
            Console.ReadLine();
        }
    }
}
