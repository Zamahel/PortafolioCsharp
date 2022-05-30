using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialDeCualquierNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long i = 0, numero, factorial = 1;

            Console.Write("Ingresa el numero para calcular su factorial: ");
            numero = Convert.ToInt32(Console.ReadLine());


            for (i = numero; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("El factorial de {0}, es: {1}", numero, factorial);

           

            
        }
    }
}
