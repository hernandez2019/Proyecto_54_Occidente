using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir dos números por teclado de tal forma que el segundo sea mayor que el primero
            //a partir del primer, imprimir los números por separados entre si 7 unidades,
            //contarlas.De estos cuantos son pares y cuanto vale la suma de los impares.
            int numero1, numero2, cantPares, sumImpares;
            cantPares = 0;
            sumImpares = 0;
            Console.Write("Ingrese un Numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro numero Mayor que el anterior: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero2 > numero1)
            {
                for (int i = numero1; i < numero2; i = i + 7)
                {
                    Console.WriteLine(i);
                    if (i % 2 == 0)
                    {
                        cantPares = cantPares + 1;
                    }
                    else
                    {
                        sumImpares = sumImpares + i;
                    }
                }

            }
            else
            {
                Console.WriteLine("El segundo numero no es mayor al primero.....");

            }
            Console.WriteLine("Numeros pares encontrados: {0}", cantPares);
            Console.WriteLine("Suma de Numeros Impares: {0}", sumImpares);
            Console.ReadKey();
        }
    }
}
