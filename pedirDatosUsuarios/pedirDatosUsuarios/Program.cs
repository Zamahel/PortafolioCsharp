using System;

namespace pedirDatosUsuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            //preguntamos el nombre del usuario
            
            Console.Write("Ingresa tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola {0} espero que te encuentres bien", nombre);

        }
    }
}
