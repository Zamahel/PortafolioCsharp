using System;

namespace ejercicioDo
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables

            decimal num1, num2, resul;
            byte opcion;

            do
            {
                //se despliega el menu

                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                //se pide y se lee la opcion

                Console.Write("Escoge una opcion: ");
                opcion = Convert.ToByte(Console.ReadLine());


                

            } while ((opcion < 1) || (opcion > 4));

            Console.Write("Dame el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dame el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //hacer la operacion escogida

            switch (opcion)
            {
                case 1:

                    resul = num1 + num2;

                    Console.WriteLine("El resultado de la suma es de: {0} ", resul);

                    break;

                case 2:

                    resul = num1 - num2;

                    Console.WriteLine("El resultado de la resta es de: {0} ", resul);

                    break;

                case 3:

                    resul = num1 * num2;

                    Console.WriteLine("El resultado de la multiplicacion es de: {0} ", resul);

                    break;

                case 4:

                    
                    if (num2 != 0)
                    {
                        resul = num1 / num2;

                        Console.WriteLine("El resultado de la division es de: {0} ", resul);

                    }
                    else
                    {
                        Console.WriteLine("No se pueden hacer divisiones entre Cero ");

                    }                    

                    break;

                default:

                    Console.WriteLine("Elige un numero entre 1 al 4");

                    break;

            }



        }
    }
}
