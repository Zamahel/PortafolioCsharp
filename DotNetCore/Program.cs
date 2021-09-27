using System;

namespace DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comprobar la mayoria de Edad
            
            byte edad;

            Console.Write("Ingresa tu edad para saber si eres mayor: ");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Felicidades eres mayor de edad tienes {0} años",edad);
            }else{
                Console.WriteLine("Lo siento eres menor de edad aun tienes {0} años",edad);
            }
        }
    }
}
