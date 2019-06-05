using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir y sumar los números desde el cero hasta un numero determinado, excepto los múltiplos
            //de 5 imprimir el valor de la suma de los múltiplos de 5.
            int numero, sumaNumeros, sumaMultiplos;
            sumaMultiplos = 0;
            sumaNumeros = 0;
            Console.Write("Ingrese un numero donde desea finalizar: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <=numero; i++)
            {
                if (i%5==0)
                {
                    sumaMultiplos = sumaMultiplos + i;
                }
                else
                {
                    Console.WriteLine(i);
                    sumaNumeros = sumaNumeros + i;
                }
            }
            Console.WriteLine("Suma de numeros Excepto los multiplos de 5: {0}", sumaNumeros);
            Console.WriteLine("Valor de la suma de los multiplos de 5: {0}", sumaMultiplos);
            Console.ReadKey();
        }
    }
}
