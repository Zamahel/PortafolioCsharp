using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float energia;
            bool propulizquierdo, propulderecho;

            Console.Write("Ingrese nivel energia (%) ");

            energia = Convert.ToSingle(Console.ReadLine());

            Console.Write("El propulsor derecho esta en buen estado?: "); 
            propulderecho = Convert.ToBoolean(Console.ReadLine());

            Console.Write("El propulsor izquierdo esta en buen estado?: ");
            propulizquierdo = Convert.ToBoolean(Console.ReadLine());

            if (((propulizquierdo && propulderecho) == (true) && energia >= 75) || (propulizquierdo || propulderecho) == true && (energia == 100) )
            {
                Console.WriteLine("Puedes despejar");
            }
            else
            {
                Console.WriteLine("Lo siento no puedes despegar");
            }

            Console.ReadKey();
        }
    }
}
