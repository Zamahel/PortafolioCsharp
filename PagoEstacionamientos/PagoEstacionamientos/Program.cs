using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoEstacionamientos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahi, los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00
             */

            double tiempoEstacionamiento;

            Console.Write("Ingresa el tiempo: ");
            tiempoEstacionamiento = Convert.ToDouble(Console.ReadLine());

            if (tiempoEstacionamiento <= 60)
            {
                Console.WriteLine("El precio a pagar es de $5.00 ");
            }
            else
            {
                if (tiempoEstacionamiento <= 120 )
                {
                    Console.WriteLine("El precio a pagar es de $15.00 ");
                }
                else
                {
                    if (tiempoEstacionamiento > 120)
                    {
                        Console.WriteLine("El precio a pagar es de $40.00 ");
                    }
                }
            }
        }
    }
}
