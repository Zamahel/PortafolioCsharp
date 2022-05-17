using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticasSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resultado;
            byte opcion;

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.Write("Escoge una opcion: ");
            opcion = Convert.ToByte(Console.ReadLine());

            Console.Write("Dame el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: {0}",resultado);
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: {0}",resultado);
                    break;
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicacion es: {0}", resultado);
                    break;
                    break;

                case 4:
                    
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("El resultado de la division es: {0}", resultado);
                        
                        

                    }
                    else
                    {
                        Console.WriteLine("No se pueden hacer divisiones entre Cero");

                    }                    
                    
                    break;              



                default:
                    Console.WriteLine("Por favor seleccione un numero del 1 al 4");
                    break;
            }

            Console.ReadKey();

        }
    }
}
