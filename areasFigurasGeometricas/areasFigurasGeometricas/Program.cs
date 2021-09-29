using System;

namespace areasFigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Metodo sin parametros ni tipo
            byte opcion;

            do
            {
                Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                Console.WriteLine("  Bienvenido Programa para calcular el area de las figuras Geometrias");
                Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
               

                Console.WriteLine("****************************************************************************");
                Console.WriteLine(" Selecciona alguna de las siguientes opciones para Calcular el Area deseada");
                Console.WriteLine("1. Triangulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Rectangulo");
                Console.Write("Cual es la opcion que Eliges: ");
                opcion = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("****************************************************************************");

            } while ((opcion < 1)  || (opcion >4));

            switch (opcion)
            {
                case 1:
                    Triangulo();
                    break;

                case 2:
                    Cuadrado();
                    break;

                case 3:
                    Rectangulo();
                    break;

                default:
                    Console.WriteLine("La opcion que escogiste NO ESTA DENTRO DE LAS OPCIONES MENCIONADAS");
                    break;
            }

            
        }

        //aqui empiezan los metodos sin parametros ni tipos de datos para calcular el area de cada figura

        static void Triangulo()
        {
            //Aqui iria el desarrollo para calcular el area del triangulo
            decimal bases, altura, resultado;

            Console.WriteLine("********************************************************************");
            Console.Write("         Ingresa el valor de la base: ");
            bases = Convert.ToDecimal(Console.ReadLine());
            Console.Write("         Ingresa el valor de la altura: ");
            altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("********************************************************************");
            resultado = ((bases * altura) / 2);
            Console.WriteLine("////////////////////////////////////////////////////////////////////");
            Console.WriteLine("El area de tu triangulo con base {0} y {1} es de: {2}",bases, altura, resultado);
            Console.WriteLine("////////////////////////////////////////////////////////////////////");
        }

        static void Cuadrado()
        {
            //Aqui iria el desarrollo para calcular el area del cuadrado
            double lado, resul;

            Console.WriteLine("********************************************************************");
            Console.Write("         Ingresa el valor del lado: ");
            lado = Convert.ToDouble(Console.ReadLine());            
            Console.WriteLine("********************************************************************");
            resul = (Math.Pow(lado,2));
            Console.WriteLine("////////////////////////////////////////////////////////////////////");
            Console.WriteLine("     El area de tu cuadrado con lado {0} es de: {1}",lado, resul);
            Console.WriteLine("////////////////////////////////////////////////////////////////////");           
        }

        static void Rectangulo()
        {
            //Aqui iria el desarrollo para calcular el area del rectangulo
            decimal bases, altura, resultado;

            Console.WriteLine("********************************************************************");
            Console.Write("         Ingresa el valor de la base: ");
            bases = Convert.ToDecimal(Console.ReadLine());
            Console.Write("         Ingresa el valor de la altura: ");
            altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("********************************************************************");
            resultado = ((bases * altura));
            Console.WriteLine("////////////////////////////////////////////////////////////////////");
            Console.WriteLine("     El area de tu rectangulo con base {0} y {1} es de: {2}", bases, altura, resultado);
            Console.WriteLine("////////////////////////////////////////////////////////////////////");            
        }
    }
}

/*
 *  YA QUEDO UNO DE TRES QUE VOY HACER PRACTICAMENTE ASI SE HACE UN MENU Y ELEGIR ENTRE LAS OPCIONES
    PERO NO ES LA UNICA FORMA DE DAR LA SOLUCION A ESTE PROBLEMA HAY VARIAS FORMAS DE HACERLO
    EL UNICO DETALLE ES FIJARTE BIEN EN COMO NOMBRAS AL METODO Y MAS ADELANTE LOS PATAMETROS
    PARA PODER OCUPARLOS
 */