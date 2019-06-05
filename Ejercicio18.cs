using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir y contar los multiplos de 3 desde la unidad hasta un número que
            //introducimos por teclado

            int numero,cnt=0;
            Console.Write("Ingrese número: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <=numero; i++)
            {
                if (i%3==0)
                {
                    Console.Write(i + " ");
                    cnt++;
                }
            }
            Console.Write("Hay " + cnt + " multiplos de 3 en "+ numero);
            Console.ReadLine();
        }
    }
}
