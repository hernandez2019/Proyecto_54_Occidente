using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir una serie de números. Sumar los múltiplos de 5. Cual es el mayor y cuantos números
            //se han introducido. SEPARADO EN 7 UNIDADES, SUMAR LOS IMPARES
            int numero, sumaMultiplos, mayor, cantSeparados, sumaImpares;
            sumaMultiplos = 0;
            mayor = 0;
            cantSeparados = 0;
            sumaImpares = 0;
            for (int i = 1; i <=10; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero %5==0)
                {
                    sumaMultiplos = sumaMultiplos + numero;
                }
                if (numero >mayor)
                {
                    mayor = numero;
                }
                if (numero %2==0)
                {
                    sumaImpares = sumaImpares + numero;
                }
            }
            Console.WriteLine("Suma de los Multiplos de 5: {0}", sumaMultiplos);
            Console.WriteLine("El mayor de los Numeros Ingresado: {0}", mayor);
            Console.WriteLine("Suma de los numeros impares: {0}", sumaImpares);
            Console.ReadKey();
        }
    }
}
