using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir y contar los números, que son a la vez múltiplos de 2 y 3, que
            //hay entre la unidad y el determinado número.
            int numero, cantNumeros;            numero = 0;            cantNumeros = 0;            Console.Write("Ingrese un Numero donde desea finalizar el conteo: ");            numero = Convert.ToInt32(Console.ReadLine());            for (int i = 1; i <=numero; i++)
            {
                if (i%2==0 && i%3==0)
                {
                    Console.WriteLine(i);
                    cantNumeros = cantNumeros + 1;
                }
            }            Console.WriteLine("Cantidad de numeros Multiplos de 2 y 3: {0}", cantNumeros);            Console.ReadKey();
        }
    }
}
