using System;

namespace areaPerimetroAreaRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, ancho, perimetro, area;

            Console.WriteLine("Ingresa los numeros para calcular el area y perimetro del rectangulo");
            Console.Write("Ingresa el valor numero 1: ");
            lado = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el valor numero 2: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            perimetro = (2 * lado + 2 * ancho);
            area = (lado * ancho);

            Console.WriteLine(" El tolal del perimetro de tu rectangulo es de {0} metros lineales", perimetro);
            Console.WriteLine(" El tolal del area de tu rectangulo es de {0} metros cuadrados", area);




        }
    }
}
