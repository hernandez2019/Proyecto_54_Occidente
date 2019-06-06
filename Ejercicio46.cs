using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir, contar y sumar los múltiplos de 2 que hay entre dos números enteros positivos,
            //tal que el segundo sea mayor o igual que el primero, los dos números deben ser ingresados vía teclado
            int numero1, numero2, cantidad=0, suma=0;
            Console.Write("Ingrese un Numero entero Positivo:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro Numero mayor que el Anterior: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero2 >= numero1)
            {
                for (int i = numero1; i <= numero2; i++)
                {
                    if (i%2==0)
                    {
                        Console.WriteLine(i);
                        cantidad = cantidad + 1;
                        suma = suma + i;
                    }
                }
                Console.WriteLine("Cantidad de Multiplos de dos: {0}", cantidad);
                Console.WriteLine("Suma de los Multiplos de dos: {0}", suma);
            }
            else
            {
                Console.WriteLine("El Segundo numero es menor que el primero... o no cumple la condicion...");
            }
            Console.ReadKey();
        }
    }
}
