using System;

namespace conversionKmAMillas
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREACION DEL MENU Y LAS VARIABLES A NECESITAR

            double centimetro, pulgada, kilometro, milla;
            byte opcion;

            do
            {
                Console.WriteLine("Escoge una opcion a realizar que aparece en el siguente menu");
                Console.WriteLine("1. Centimetros a Pulgadas");
                Console.WriteLine("2. Pulgadas a Centimetros");
                Console.WriteLine("3. Kilometros a Millas");
                Console.WriteLine("4. Millas a Kilometros");
                Console.Write("Elige una opcion: ");
                opcion = Convert.ToByte(Console.ReadLine());

            } while ((opcion < 1) || (opcion > 4));

            switch (opcion)
            {
                case 1:
                    centimetro = Centimetros();

                    Console.WriteLine("El resultado de la conversion es de {0} centimetros", centimetro);

                    break;

                case 2:
                    pulgada = Pulgas();

                    Console.WriteLine("El resultado de la conversion es de {0} pulgadas", pulgada);
                    break;

                case 3:
                    kilometro = Kilometros();

                    Console.WriteLine("El resultado de la conversion es de {0} kilometros", kilometro);

                    break;

                case 4:
                    milla = Millas();

                    Console.WriteLine("El resultado de la conversion es de {0} millas", milla);
                    break;

                default:
                    break;
            }
        }


        static double Centimetros()
        {
            double pulgadas, centimetro;

            Console.Write("Ingresa las pulgadas para convertirlas a centimetros: ");
            pulgadas = Convert.ToDouble(Console.ReadLine());

            centimetro = (pulgadas * 2.54);

            return centimetro;

        }

        static double Pulgas()
        {
            double pulgada, centimetro;

            Console.Write("Ingresa los centimetros para convertirlas a pulgadas: ");
            centimetro = Convert.ToDouble(Console.ReadLine());

            pulgada = (centimetro / 2.54);

            return pulgada;

        }

        static double Kilometros()
        {
            double kilometro, milla;

            Console.Write("Ingresa las millas para convertirlas a kilometros: ");
            milla = Convert.ToDouble(Console.ReadLine());

            kilometro = (milla / 1.609344);

            return kilometro;
        }

        static double Millas()
        {
            double kilometro, milla;

            Console.Write("Ingresa los kilometros para convertirlas a millas: ");
            kilometro = Convert.ToDouble(Console.ReadLine());

            milla = (kilometro * 0.62137);

            return milla;

        }
    }
}
