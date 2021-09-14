using System;

namespace potenciasNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int potencia, numero;
            double resul;

            Console.Write("Ingresa el numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa  potencia ");
            potencia = Convert.ToInt32(Console.ReadLine());

            resul = Math.Pow(numero, potencia);

            Console.WriteLine("La potencia de {0} elevado a {1} es de {2} ",numero, potencia, resul);



        }
    }
}
