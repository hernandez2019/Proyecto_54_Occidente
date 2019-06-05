using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir y contar los números que son multiplos de 2 o 3 que hay del 1 al 100
            int opc, cnt=0;
            Console.WriteLine("1) Multiplos de 2 ");
            Console.WriteLine("2) Multiplos de 3 ");
            Console.Write(" Opción: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    for (int i = 1; i <=100 ; i++)
                    {
                        if (i%2==0)
                        {
                            Console.Write(i+" ");
                            cnt++;
                        }
                    }
                    Console.Write("\nHay "+ cnt + " multiplos de 2");
                   break;
                case 2:
                    for (int i = 1; i <= 100; i++)
                    {
                        if (i % 3 == 0)
                        {
                            Console.Write(i + " ");
                            cnt++;
                        }
                    }
                    Console.Write("\nHay " + cnt + " multiplos de 3");
                    break;
                default:
                    
                    Console.WriteLine("Esa opción no existe");
                    break;
            }
            Console.ReadLine();
        }
    }
}
