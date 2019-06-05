using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir un número por teclado menor que 100. imprimir la suma de los cuadrados 
            //de los números que estan separados entre si 4 posiciones.

            int numero;
            double cuadrados;
            double suma = 0;
            Console.Write("Ingrese número: ");
            numero = int.Parse(Console.ReadLine());
            if (numero<=100)
            {
                for (int i = 0; i <=numero; i++)
                {
                    if (i%4==0)
                    {
                        cuadrados = Math.Pow(i, 2);
                        suma = suma + cuadrados;
                    }
                }
                Console.Write("La suma de los cuadrados del 4 al " + numero +" es: "+suma);
                Console.ReadLine();
            }

        }
    }
}
