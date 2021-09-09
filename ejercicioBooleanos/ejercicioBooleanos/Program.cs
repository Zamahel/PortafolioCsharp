using System;

namespace ejercicioBooleanos
{
    class Program
    {
        static void Main(string[] args)
        {
            float energia;
            bool propulsorIzq, propulsorDer;

            Console.Write("Ingresa el nivel de energia (%): ");
            energia = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("El propulsor izquierdo esta en ben estado? ");
            propulsorIzq = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("El propulsor derecho esta en ben estado? ");
            propulsorDer = Convert.ToBoolean(Console.ReadLine());

            if (((propulsorIzq && propulsorDer) == true) && energia >= 75 || ((propulsorIzq || propulsorDer == true) && (energia == 100)))
            {
                Console.WriteLine("Puedes despegar");
            }
            else
            {
                Console.WriteLine("No puedes despegar");
            }

        }
    }
}
