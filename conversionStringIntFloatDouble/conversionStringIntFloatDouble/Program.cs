using System;

namespace conversionStringIntFloatDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int numero1=5, numero2, resultado;

            Console.Write("Ingresa tu numero: ");
            entrada = Console.ReadLine();

            numero2 = Convert.ToInt32(entrada);

            resultado = numero1 + numero2;

            Console.WriteLine(" La suma de {0} + {1} es de: {2}", numero1, numero2, resultado);

        }
    }
}
