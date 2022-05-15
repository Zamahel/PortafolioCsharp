using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color;

            Console.WriteLine("Ingresa el color RGB: ");

            color = Console.ReadLine();

            switch (color)
            {
                case "red":
                case "Red":
                case "RED":
                    Console.WriteLine("El codigo RGB para {0} es: 255,0,0",color);
                break;

                case "green":
                case "Green":
                case "GREEN":
                    Console.WriteLine("El codigo RGB para {0} es: 0,255,0",color);
                    break;

                case "blue":
                case "Blue":
                case "BLUE":
                    Console.WriteLine("El codigo RGB para {0} es: 0,0,255", color);
                    break;

                    default:
                    Console.WriteLine("No se ha encontrado coincidencia en la seleccion de los colores");
                    break;
            }

            Console.ReadKey();
        }
    }
}
