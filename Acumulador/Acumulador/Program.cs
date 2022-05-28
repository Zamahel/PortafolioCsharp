using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acumulador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Acumulador = acumulador + variable == acumulador += variable*/
            int i, acumulador = 0, precio;

            for (i = 1; i <= 5; i++)
            {
                Console.Write("Ingresa el precio del producto: ");
                precio = Convert.ToInt32(Console.ReadLine());

                acumulador += precio;

                

            }

            Console.WriteLine("Tu total a pagar es: {0}", acumulador);

        }
    }
}
