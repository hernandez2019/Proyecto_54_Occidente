using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un algoritmo que imprima todos los numeros naturales que hay desde la unidad
            //hasta un número introducido por teclado.

            int valor;
            Console.Write("Ingrese un número: ");
            valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
