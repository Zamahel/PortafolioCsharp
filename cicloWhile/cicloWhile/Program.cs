using System;

namespace cicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong numero = 1;

            while (numero <= 10000000000000000000)
            {
                Console.WriteLine(numero);
                numero++;
            }
        }
    }
}
