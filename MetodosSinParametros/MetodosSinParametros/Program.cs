using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosSinParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Suma");
                Console.WriteLine("4. Suma");

                //Escoge una opcion
                Console.WriteLine("Elige una opcion del 1 al 4");
                opcion = Convert.ToInt32(Console.ReadLine());

            } while ((opcion < 1) || (opcion > 4));

            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;

                case 2:
                    Restar();
                    break;

                case 3:
                    Multiplicar();
                    break;

                case 4:
                    Dividir();
                    break;

                default:
                    break;
            }
        }

        //Cierre del Main

        //[modificador] [tipo] [parametros]

        static void Sumar()
        {
            //Variables del metodo de Sumar()
            decimal num1, num2, resultado;

            //Pedimos el valor de ambos numeros
            Console.Write("Ingressa el Primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo numero:");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 + num2;

            Console.Write("{0} + {1} = {2}", num1, num2, resultado);
            Console.ReadKey();

        }

        static void Restar()
        {
            //Variables del metodo de Sumar()
            decimal num1, num2, resultado;

            //Pedimos el valor de ambos numeros
            Console.Write("Ingressa el Primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo numero:");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 - num2;

            Console.Write("{0} - {1} = {2}", num1, num2, resultado);
            Console.ReadKey();

        }

        static void Multiplicar()
        {
            //Variables del metodo de Sumar()
            decimal num1, num2, resultado;

            //Pedimos el valor de ambos numeros
            Console.Write("Ingressa el Primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo numero:");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 * num2;

            Console.Write("{0} * {1} = {2}", num1, num2, resultado);
            Console.ReadKey();

        }

        static void Dividir()
        {
            //Variables del metodo de Sumar()
            decimal num1, num2, resultado;

            //Pedimos el valor de ambos numeros
            Console.Write("Ingressa el Primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo numero:");
            num2 = Convert.ToDecimal(Console.ReadLine());


            if (num2 == 0)
            {
                Console.WriteLine("No se pude dividir entre cero");


            }
            else
            {
                resultado = num1 / num2;

                Console.Write("{0} / {1} = {2}", num1, num2, resultado);
                Console.ReadKey();
            }

            Console.ReadKey();           
            

        }


    }
}
