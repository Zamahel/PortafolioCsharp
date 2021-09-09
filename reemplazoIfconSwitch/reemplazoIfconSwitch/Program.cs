using System;

namespace reemplazoIfconSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resul;
            byte opcion;

            Console.WriteLine("**********************************************");
            Console.WriteLine(" Elige una opcion para realizar una operacion");
            Console.WriteLine("**********************************************");

            Console.WriteLine("1. Suma: ");
            Console.WriteLine("2. Resta: ");
            Console.WriteLine("3. Multiplicacion: ");
            Console.WriteLine("4. Division: ");

            Console.Write("Ingresa una opcion: ");
            opcion = Convert.ToByte(Console.ReadLine());

            Console.Write("Dame el numero 1: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el numero 2: ");
            num2 = Convert.ToDecimal(Console.ReadLine());



            switch (opcion)
            {

                case 1:

                    resul = num1 + num2;

                    Console.WriteLine("La suma de {0} + {1} es de: {2}",num1, num2, resul);

                    break;

                case 2:

                    resul = num1 - num2;

                    Console.WriteLine("La resta de {0} - {1} es de: {2}", num1, num2, resul);

                    break;

                case 3:

                    resul = num1 * num2;

                    Console.WriteLine("La multiplicacion de {0} * {1} es de: {2} ", num1, num2, resul);

                    break;

                case 4:
                                        

                    if (num2 != 0)
                    {
                        resul = num1 / num2;
                        Console.WriteLine("La division de {0} / {1} es de: {2}", num1, num2, resul);
                    }
                    else
                    {
                        Console.WriteLine("No se puede hacer divisiones entre cero");
                    }

                    

                    break;

                default:
                    Console.WriteLine("Escoge un valor entre 1 al 4");
                    break;


            }


        }
    }

}
