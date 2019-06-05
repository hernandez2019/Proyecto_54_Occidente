using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un algoritmo que imprima el mayor el menor de una serie de
            //cinco números que vamos introduciendo por teclado.
            int mayor, menor,numero;
            mayor = 0;
            menor = 0;
            numero = 0;
            for (int i = 1; i <=5; i++)
            {
                Console.Write("Ingrese un numero:");
                numero = Convert.ToInt32(Console.ReadLine());
                if (mayor ==0)
                {
                    mayor = numero;
                    menor = 0;
                }
                if (numero >mayor)
                {
                        mayor = numero;
                        menor = mayor;
                }
                if (numero <menor)
                {
                    menor = numero;
                }
            }
            Console.WriteLine("El numero mayor es: {0}", mayor);
            Console.WriteLine("El numero menor es: {0}", menor);
            Console.ReadKey();
        }
    }
}
