using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioConDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resultado;
            byte opcion;

            

            do
            {
                /*Desplegamos el menu*/
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                /*Pedimos al usuario que ingrese una opcion*/
                Console.Write("Escoge una opcion: ");
                opcion = Convert.ToByte(Console.ReadLine());

            }
            while ((opcion < 1) || (opcion >4));

            /*Pedimos los dos numeros*/
            Console.Write("Dame el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                   
                    resultado = num1 + num2;
                    Console.Write("El resultado de la suma es de {0} ", resultado);

                    break;

                case 2:

                    resultado = num1 - num2;
                    Console.Write("El resultado de la resta es de {0} ", resultado);
                    

                    break;

                case 3:

                    resultado = num1 * num2;
                    Console.Write("El resultado de la multiplicacion es de {0} ", resultado);
                    

                    break;

                case 4:

                    if (num2 != 0)
                    {
                        resultado = num1 / num2;                        
                        Console.Write("El resultado de la division es de {0}", resultado);
                    }
                    else
                    {
                        Console.Write("No se pueden dividir numeros entre cero");
                    }                   

                    break;

                default:
                    Console.WriteLine("Elige un numero entre 1 y el 4 ");
                    break;
            }

            Console.ReadKey();


        }
    }
}
