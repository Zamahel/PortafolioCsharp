using System;

namespace segundoEjercicioCicloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular la factorial de un numero N

            ulong i, numero, factorial = 1;


            Console.Write("Ingresa el numero para calcular la factorial: ");
            numero = Convert.ToUInt64(Console.ReadLine());

            for (i = numero; i >= 1 ; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("La factorial de {0}, es {1} ", numero, factorial);
        }
    }
}
