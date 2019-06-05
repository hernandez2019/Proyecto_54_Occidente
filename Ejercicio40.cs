using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular el menor numero primo de un numero que introducimos vía teclado.
            int c = 0, aux = 0, cp = 0, numero = 0;
            Console .Write("Ingrese un valor: ");
            numero = Convert .ToInt32 (Console .ReadLine ());
            while (c < numero)
            {
                c++;
                while (aux < c)
                {
                    aux++;
                    if (c % aux == 0)
                    {
                        cp++;
                    }
                }
                if (cp == 2)
                {
                    Console .WriteLine(" "+c);

                }
                cp = 0;
                aux = 0;
            }
            Console .WriteLine("El menor numero primos es: 2");
            Console.ReadKey();

        }
    }
}
