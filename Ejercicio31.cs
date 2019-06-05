using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir diez veces la serie de números del 1 al 10
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("==========Serie {0}==========", i);
                for (int n = 1; n <=10; n++)
                {
                    Console.WriteLine(n);
                }

            }
            Console.ReadKey();
        }
    }
}
