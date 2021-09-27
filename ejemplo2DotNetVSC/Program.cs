using System;

namespace ejemplo2DotNetVSC
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;

            Console.Write("Escoje un numero del 1 al 12 para saber el mes del año que corresponde al numero: ");
            mes = Console.ReadLine();

            switch (mes){
                case "1":
                    Console.WriteLine("Enero");
                    break;

                case "2":
                    Console.WriteLine("Febrero");
                    break;

                    default:
                    Console.WriteLine("Escoje un NUMERO DEL 1 AL 12");
                    break;
                    
            }
        }
    }
}
