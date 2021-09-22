using System;

namespace calculoDeRadioPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0, perimetro = 0, radio, diametro;


            Console.WriteLine("Calculo del area y perimetro del circulo");

            Console.Write("Ingresa el radio: ");
            radio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el diametro: ");
            diametro = Convert.ToDouble(Console.ReadLine());

            perimetro = ((Math.PI) * diametro);
           
            radio = Math.Pow(radio, 2);
            area = ((Math.PI) * radio);

            Console.WriteLine("El area del circulo es: {0}",perimetro);

            Console.WriteLine("El perimetro del circulo es: {0}", area);

           

        }
    }
}
