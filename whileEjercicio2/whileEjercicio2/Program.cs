using System;

namespace whileEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña1, contraseña2 = "";

            Console.Write("Escribe tu contraseña: ");
            contraseña1 = Console.ReadLine();

            while (contraseña1 != contraseña2)
            {
                Console.Write("Confirma tu contraseña: ");
                contraseña2 = Console.ReadLine();
            }

            Console.WriteLine("Contraseña Guardada");

        }
    }
}
