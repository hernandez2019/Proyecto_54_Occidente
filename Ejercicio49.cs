using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que permite ingresar 3 números enteros diferentes por teclado,
            //y a continuación imprima la suma, la media aritmética, el menor, el mayor de estos números.
            int n1 = 0, n2 = 0,n3 = 0,suma,media;
            int mayor = 0, menor = 0;
            Console .Write("Ingrese el primer Valor: ");
            n1 = Convert .ToInt32 (Console .ReadLine ());
            Console.Write("Ingrese el Segundo Valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Tercer Valor: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            suma = n1 + n2 + n3;
            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("==================================================");
            Console.WriteLine("La suma de los tres números leídos, es: " +suma);
            Console.WriteLine("La La media aritmética de los tres números leídos, es: " +media);
            if (n1 > n2)
            {
                mayor = n1;
                n1 = n2;
                n2 = mayor;
            }
            if (n1 > n3)
            {
                mayor = n1;
                n1 = n3;
                n3 = mayor;
            }
            if (n2 > n3)
            {
                mayor = n2;
                n2 = n3;
                n3 = mayor;
            }
            mayor = n3;
            menor = n1;
            Console .WriteLine ("El número MAYOR leído es: " +mayor);
            Console .WriteLine ("El número MENOR leído es: " +menor);
            Console.ReadKey();

        }
    }
}
