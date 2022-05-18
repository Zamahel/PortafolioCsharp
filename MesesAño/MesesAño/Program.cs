using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesesAño
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que le pida al usuario un numero del 1 al 12 y que escriba el nombre del mes que corresponde ese numero en el calendario. Agregar un case default
             */

            byte numeroMes;

            Console.Write("Escribe un numero del 1 al 12 para decirte el mes que le corresponde: ");
            numeroMes = Convert.ToByte(Console.ReadLine());

            switch (numeroMes)
            {
                case 1:
                    Console.WriteLine("El mes que le corresponde es ENERO");
                    break;

                case 2:
                    Console.WriteLine("El mes que le corresponde es FEBRERO");
                    break;

                case 3:
                    Console.WriteLine("El mes que le corresponde es MARZO");
                    break;

                case 4:
                    Console.WriteLine("El mes que le corresponde es ABRIL");
                    break;

                case 5:
                    Console.WriteLine("El mes que le corresponde es MAYO");
                    break;

                case 6:
                    Console.WriteLine("El mes que le corresponde es JUNIO");
                    break;

                case 7:
                    Console.WriteLine("El mes que le corresponde es JULIO");
                    break;

                case 8:
                    Console.WriteLine("El mes que le corresponde es AGOSTO");
                    break;

                case 9:
                    Console.WriteLine("El mes que le corresponde es SEPTIEMBRE");
                    break;

                case 10:
                    Console.WriteLine("El mes que le corresponde es OCTUBRE");
                    break;

                case 11:
                    Console.WriteLine("El mes que le corresponde es NOVIEMBRE");
                    break;

                case 12:
                    Console.WriteLine("El mes que le corresponde es DICIEMBRE");
                    break;

                default:
                    Console.WriteLine("SELECCIONA UN NUMERO DEL 1 AL 12");  
                    break;
            }
        }
    }
}
