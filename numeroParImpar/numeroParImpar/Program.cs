using System;

namespace numeroParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, residuo;

            Console.WriteLine("Ingresa un numero para decirte si es par o impar: ");


            numero = Convert.ToDouble(Console.ReadLine());

            residuo = numero % 2;

            if (residuo == 0)
            {
                Console.WriteLine("El numero {0} es par ", residuo);

            }
            else
            {
                Console.WriteLine("Tu numero es impar ");
            }


        }
    }
}
