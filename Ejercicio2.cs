using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace del_100_al_0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un algoritmo que imprima los número del 100 al 0;
            for (int i = 100; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
