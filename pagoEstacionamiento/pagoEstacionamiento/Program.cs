using System;

namespace pagoEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            double tiempo;

            Console.Write("Coloca el tiempo para poderte cobrar: ");
            tiempo = Convert.ToDouble(Console.ReadLine());

            if (tiempo <= 60)
            {
                Console.WriteLine("Se te cobraran $5.00");
            }
            else
            {
                if (tiempo > 60 || tiempo < 120)
                {
                    Console.WriteLine("Se te cobraran $15.00");
                }
                else
                {
                    if (tiempo > 120)
                    {
                        Console.WriteLine("Se te cobraran $40.00");
                    }
                }
            }
        }
    }
}
