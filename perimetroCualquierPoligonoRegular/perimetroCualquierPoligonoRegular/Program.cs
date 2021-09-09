using System;

namespace perimetroCualquierPoligonoRegular
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimetro, nLados, longitud;

            Console.WriteLine("Programa para calcular el perimetro de cualquier Poligono");
            Console.Write("Ingre el numero de lados : ");
            nLados = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la longitud : ");
            longitud = Convert.ToDouble(Console.ReadLine());

            perimetro = nLados * longitud;

            Console.WriteLine("El perimetro de tu figura es de:  {0}", perimetro);
            


        }
    }
}
