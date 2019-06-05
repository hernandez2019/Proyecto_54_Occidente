using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que determine cuantas cifras posee un número
            //entero positivo introducido por teclado.repetir el proceso
            int numero = 0, cant = 0;
            Console .Write ("Ingrese un numero entero positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero >= 10)
            {
                cant++;
                numero = numero / 10;
            }
            Console .WriteLine ("El número tiene: " +(cant + 1) + " dígitos");
            Console.ReadKey();

        }
    }
}
