using System;

namespace ejercicioCicloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i, numAlumnos;
            double calificacion, sumaCali = 0, promedio;

            Console.Write("Ingresa el numero de Alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for (i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Dame la calificacion del alumno: ");
                calificacion = Convert.ToDouble(Console.ReadLine());

                sumaCali += calificacion;
            }

            promedio = sumaCali / numAlumnos;

            Console.WriteLine("El promedio es: {0} ", promedio);

        }
    }
}
