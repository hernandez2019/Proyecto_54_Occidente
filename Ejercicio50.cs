using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escriba un programa que lea un el radio de la circunferencia y que imprima el diámetro,
            //la circunferencia y su área.Utilice el valor constante 3.14159 para PI (p)o utilice la clase Math
            double n1 = 0, pi = 3.14159, diametro, circun, area;
            Console .Write("Introduzca el Radio de la circunferencia: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            diametro = n1 / pi;
            area = (pi * (n1 * n1));
            circun = ((2 * pi) * n1);
            Console.WriteLine("============================================");
            Console.WriteLine("El diámetro es: " +diametro);
            Console .WriteLine("La Circunferencia es: " +circun);
            Console .WriteLine("El área es: " +area);
            Console.ReadKey();

        }
    }
}
