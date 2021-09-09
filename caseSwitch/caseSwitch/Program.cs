using System;

namespace caseSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string color;

            Console.Write("Escoge el color para darte el codigo RGB: ");
            color = Console.ReadLine();

            switch (color)
            {

                case "Red":
                case "red":
                case "RED":

                    Console.WriteLine("El codigo RGB para {0} es: 255, 0, 0", color);
                
                 break;

                case "Green":
                case "GREEN":
                case "green":


                    Console.WriteLine("El codigo RGB para {0} es: 0, 255, 0", color);

                    break;

                case "Blue":
                case "BLUE":
                case "blue":

                    Console.WriteLine("El codigo RGB para {0} es: 0, 0, 255", color);

                    break;


                default:
                    Console.WriteLine("No se encontro el codigo RGB para el color que escribiste intenta de nuevo");
                    break;
            }
        }
    }
}
