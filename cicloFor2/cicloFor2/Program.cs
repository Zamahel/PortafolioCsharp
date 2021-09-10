using System;

namespace cicloFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            //la variable se puede declarar normalmente o dentro del "for"
            //Aqui solo puede ocupar "i" dentro de "for"

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

           
            Console.WriteLine("===============================================");

            //Aqui la variable "incremento" se puede ocupar en cualquier parte del programa

            int incremento;

            for (incremento = 1; incremento <= 20; incremento++)
            {
                Console.WriteLine(incremento);
            }
        }
    }
}
