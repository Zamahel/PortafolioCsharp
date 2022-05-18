using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroParEImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             HACER UN PROGRAMA QUE LE PIDA AL USUARIO UN NUMERO Y DECIRLE SI ESTE ES PAR O IMPAR
             */

            double numero, resultado;

            Console.Write("Ingresa el numero a verificar: ");
            numero = Convert.ToDouble(Console.ReadLine());

            resultado = numero % 2;

            if (resultado != 0)
            {
                Console.WriteLine("Tu numero es impar");
            }
            else
            {
                Console.WriteLine("Tu numero es par");
            }
        
        }
    }
}
