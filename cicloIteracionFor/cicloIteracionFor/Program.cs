using System;

namespace cicloIteracionFor
{
    class Program
    {
        static void Main(string[] args)
        {

            //variable
            double cal1, cal2, cal3, prom;

            //Se hacen la peticion de las calificaciones
            Console.WriteLine("Dame la calificacion del primer alumno");
            cal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame la calificacion del segundo alumno");
            cal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame la calificacion del tercer alumno");
            cal3 = Convert.ToDouble(Console.ReadLine());

            //se calcula el promedio

            prom = (cal1 + cal2 + cal3 ) / 3;

            //Mostramos el promedio

            Console.WriteLine("El promedio es: {0}", prom);
        }
    }
}
