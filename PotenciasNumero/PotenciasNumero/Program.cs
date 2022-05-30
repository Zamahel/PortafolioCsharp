using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotenciasNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numero, potencia, resultado;

            Console.WriteLine("Ingresa el numero: ");
            numero = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Ingresa la potencia: ");
            potencia = Convert.ToInt64(Console.ReadLine());

            Console.Write(Math.Pow(numero, potencia));

            Console.ReadKey();

        }
        
        
    }
}
