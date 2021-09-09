using System;

namespace convertirSinCadenaString
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resul;

            Console.Write("Ingresa el numero 1 para sumarlo: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el numero 2 para sumarlo: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            resul = num1 + num2;


            Console.WriteLine("La suma de {0} + {1} es de {2} ",num1, num2, resul);
        }
    }
}
