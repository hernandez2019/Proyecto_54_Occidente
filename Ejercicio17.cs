using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir un número por teclado. que nos diga si es par o impar
            int numero;
            Console.Write("Ingrese número: ");
            numero = int.Parse(Console.ReadLine());
            if (numero%2== 0)
            {
                Console.Write("El número " + numero + " es par");
            }
            else
            {
                Console.Write("El número " + numero + " es impar");
            }
            Console.ReadLine();
        }
    }
}
