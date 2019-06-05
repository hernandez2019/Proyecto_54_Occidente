using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular e imprimar la factorial de un número ingresado vía teclado.
            int numero = 0,fact=1;
            Console.Write("Ingrese un numero a calcular el Factorial: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=numero; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("El Factorial del numero ingresado es: {0}", fact);
            Console.ReadKey();
        }
    }
}
