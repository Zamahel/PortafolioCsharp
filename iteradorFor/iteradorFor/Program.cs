using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteradorFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ASIGNACION COMPUESTA (X-= 5) == (X= X - 5)*/

            int i;

            for (i = 10; i >= 1; Console.WriteLine("Valor de Salida: {0}", i), i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
