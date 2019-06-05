using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introducir una serie de números. Decir si esos números son mayores o menores de 10.
            int numero = 0;
            string mayores, menores;
            mayores = "";
            menores = "";
            for (int i = 1; i < 10; i++)
            {
                Console.Write("Ingrese un Numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero>10)
                {
                    mayores =mayores+ "" + numero + ",";
                }
                else
                {
                    menores =menores+"" + numero + ",";
                }
            }
            Console.WriteLine("Los numeros: {0}", mayores + " " + "Son mayores que 10");
            Console.WriteLine("Los numeros: {0}", menores + " " + "Son Menores que 10");
            Console.ReadKey();
        }
    }
}
