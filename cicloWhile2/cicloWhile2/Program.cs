using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*contraseña del ciclo While se ocupa cuando no sabemos el numero de veces que se 
             va a repetir el ciclo*/
            string contraseña1, contraseña2 = " ";

            Console.Write("Escoge una contaseña: ");
            contraseña1 = Console.ReadLine();

            while (contraseña1 != contraseña2)
            {
                Console.WriteLine("Confirmar tu contraseña");
                contraseña2 = Console.ReadLine();
            }

            Console.WriteLine("Contraseña guardada");
        }
    }
}
