using System;

namespace centigradosFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrengeith, celcius, res;

            Console.Write("Ingresa los grados Celcius para convertir a Fahrengeith: ");
            celcius = Convert.ToDouble(Console.ReadLine());
            res = ((celcius * 1.8) + 32);
            Console.WriteLine("Tus grados Fahrengeith es de: {0} ",res);






            Console.Write("Ingresa los grados Fahrengeith para convertir a Celcius: ");
            fahrengeith = Convert.ToDouble(Console.ReadLine());
            res = ((fahrengeith - 32) / 1.8);
            Console.WriteLine("Tus grados Celcius es de: {0} ", res);

        }
    }
}
