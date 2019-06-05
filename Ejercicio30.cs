using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir una cantidad por teclado.Si es menor que 500, sumarle el 50 por ciento;
            //si es mayor o igual a 500 pero menor que 1000, sumarle el 7 por ciento;
            //si es mayor que 1000 y menor o igual a 5000, restarle el 5 por ciento.
            int cantidad;
            Console.Write("Ingrese una Cantidad: ");            cantidad = Convert.ToInt32(Console.ReadLine());            if (cantidad <500)
            {
                Console.WriteLine("\n ========================");
                Console.WriteLine("El numero que ingreso es: {0}", cantidad);
                cantidad = cantidad + (cantidad * 50 / 100);
                Console.WriteLine("Total mas 50%: {0}", cantidad);
                
            }            else if (cantidad >=500 && cantidad <1000)
            {
                Console.WriteLine("\n ========================");
                Console.WriteLine("El numero que ingreso es: {0}", cantidad);
                cantidad = cantidad + (cantidad * 7 / 100);
                Console.WriteLine("Total mas 7%: {0}", cantidad);
            }            else if(cantidad >1000 && cantidad <=5000)
            {
                Console.WriteLine("\n ========================");
                Console.WriteLine("El numero que ingreso es: {0}", cantidad);
                cantidad = cantidad - (cantidad * 5 / 100);
                Console.WriteLine("Total menos 5%: {0}", cantidad);
            }            Console.ReadKey();
        }
    }
}
