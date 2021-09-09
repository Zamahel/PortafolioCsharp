using System;

namespace ifAnidadosCase
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


          

            if (opcion == 1)
            {
                resul = num1 + num2;

                Console.WriteLine("El resultado de la suma es de: {0} ", resul);

            }
            else
            {
                if (opcion == 2)
                {
                    resul = num1 - num2;

                    Console.WriteLine("El resultado de la resta es de: {0} ", resul);
                }
                else
                {
                    if (opcion == 3)
                    {
                        resul = num1 * num2;

                        Console.WriteLine("El resultado de la multiplicacion es de: {0} ", resul);
                    }
                    else
                    {
                        if (opcion == 4)
                        {
                            if (num2 != 0)
                            {
                                resul = num1 / num2;
                                Console.WriteLine("El resultado de la division es de: {0}", resul);             
                                
                            }
                            else
                            {
                                Console.WriteLine("No se pueden hacer Divisiones entre Cero");
                            }
                        }
                    }
                }
            }
        }
    }
}
