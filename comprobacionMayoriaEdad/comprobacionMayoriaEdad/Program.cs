using System;

namespace comprobacionMayoriaEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            byte edad;

            Console.Write("Que edad tienes: ");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad puedes pasar");
            }
            else
            {
                Console.WriteLine("Eres menor de edad no puedes pasar");
            }
        }
    }
}
