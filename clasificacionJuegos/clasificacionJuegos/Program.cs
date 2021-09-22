using System;

namespace clasificacionJuegos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.Write(" Ingresa la edad para darte la clasificacion del juego: ");

            edad = Convert.ToInt32(Console.ReadLine());

            if (edad <= 12)
            {
                Console.WriteLine("Contenido para todo publico A");
                Console.WriteLine("Clasificacion internacional EVERYONE");
            }
            else
            {
                if (edad <= 17)
                {
                    Console.WriteLine("Contenido apto a partir de doce años a 15 B B15");

                    Console.WriteLine("Clasificacion internacional EVERYONE +10");
                    Console.WriteLine("Clasificacion internacional TEEN");

                }
                else 
                {
                    if (edad >=18)
                    {
                        Console.WriteLine("Contenido apto solo para adutos D");
                        Console.WriteLine("Clasificacion internacional MATURE 17+");
                        Console.WriteLine("Clasificacion internacional ADULT ONLY 18+");
                    }
                }
            }

        }
    }
}
