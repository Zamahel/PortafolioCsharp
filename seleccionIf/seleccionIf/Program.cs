using System;

namespace seleccionIf
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero;

            Console.Write("Dame un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                if (numero < 0)
                {
                    Console.WriteLine("El numero es negativo");
                }
            }
             
        }
    }
}
