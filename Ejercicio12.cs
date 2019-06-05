using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir, contar y sumar los multiplos de 10 hasta un número que introducimos por teclado
            int suma = 0, cnt = 0, valor;


            Console.Write("Ingrese número: ");
            valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                if (i % 10 == 0)
                {
                    Console.Write(i + " ");
                    cnt++;
                    suma = suma + i;
                }
            }
            Console.Write("\n ");
            Console.Write("El total de la suma es: " + suma + " \n");
            Console.Write("Hay " + cnt + " multiplos entre el 1 al " + valor);
            Console.ReadLine();
        }
    }
}
