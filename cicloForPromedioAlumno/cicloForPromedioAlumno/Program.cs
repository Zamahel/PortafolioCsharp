using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicloForPromedioAlumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i, alumnos;
            double calificacion, sumaCali= 0, promedio;

            Console.Write("Ingrese el numero de alumnos: ");
            alumnos = Convert.ToByte(Console.ReadLine());

            for (i = 1; i <= alumnos; i++)
            {
                Console.Write("ingrese la calificacion del alumno: ");
                calificacion = Convert.ToByte(Console.ReadLine());

                 
                 sumaCali += calificacion;

                
            }

            promedio = sumaCali / alumnos;

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.ReadKey();



        }
    }
}
