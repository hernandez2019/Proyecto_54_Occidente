using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir un número por teclado menor que 500. imprimir,
            //sumar y contar los números que estan separados entre si 8 posiciones, desde ese número al 500

            int numero, cnt = 0, suma = 0;

                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero <= 500)
                {
                    for (int i = 0; i <=500; i++)
                    {
                        if (i%8==0)
                        {
                            Console.Write(i+" ");
                            cnt++;
                            suma = suma + i;
                        }
                    }
                }


            Console.Write("\nEl total de la suma es:  "+ suma);
            Console.Write("\nHay:  " + cnt + " multiplos de 8");
            Console.ReadLine();
        }
    }
}
