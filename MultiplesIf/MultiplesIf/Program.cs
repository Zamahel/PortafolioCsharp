using System;

namespace MultiplesIf
{
    class Program
    {
        static void Main(string[] args)
        {
            double divisor, dividendo, resul;

            Console.Write("Dame el dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame el divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());


            if (divisor != 0)
            {
                resul = dividendo / divisor;

                Console.WriteLine("El resultado de la division es: {0}", resul);
            }
            else
            {
                Console.WriteLine("No se puede dividir numeros entre cero");
            }
           
        }
    }
}
