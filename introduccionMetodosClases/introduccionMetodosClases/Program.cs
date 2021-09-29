using System;

namespace introduccionMetodosClases
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            decimal r;//alacena el valor devuelto de restar();
            decimal num1Argumento, num2Argumento;//Argumento para enviar una copia del valor a los metodos Multiplicar();

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                Console.Write("Escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion >4));


            switch (opcion)
            {
               // 1.Metodos sin parametros ni tipo
                case 1:
                    Sumar();
                    break;

                // 2. Metodos con parametros
                case 2:
                    r = Restar();//asignamos a r el valor devuelto por return

                    Console.WriteLine("El resultado de la resta es: {0}", r);

                    break;

                //3. Metodos que devuelven un tipo
                case 3:

                    num1Argumento = IngresarNumero("Ingresar el primer numero: ");
                    num2Argumento = IngresarNumero("Ingresar el segundo numero: ");

                    //Invocacion del metodo
                    Multiplicar(num1Argumento, num2Argumento);                    
                    break;

                //4.Metodos con parametros y que devuelven un tipo
                case 4:
                    //pedimos el valor de ambos numeros

                    num1Argumento = IngresarNumero("Ingresar el primer numero: ");
                    num2Argumento = IngresarNumero("Ingresar el segundo numero: ");

                    //Invocacion del metodo
                    Multiplicar(num1Argumento, num2Argumento);

                    r = Dividir(num1Argumento, num2Argumento);

                    Console.WriteLine("El resultado de la division es: {0}", r);

                    break;

                default:

                    Console.WriteLine("Elige una opcion entre el 1 al 4 ");

                    break;
            }


        }

        //Sintaxis de los metodos

        //[modificador] [tipo] [identificador] [parametros]

        //1. Metodos sin parametros ni tipo
        static void Sumar()
        {
            //Instrucciones
            decimal num1, num2, resultado;

            Console.Write("Ingresa el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}",num1, num2, resultado);

        }

        //2. Metodos con parametros
        static decimal Restar()
        {
            decimal num1, num2, resultado;
            Console.Write("Ingresa el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 - num2;
            //se devuelve el valor 
            return resultado;
        }

        //3. Metodos que devuelven un tipo
        static void Multiplicar(decimal num1Parametro, decimal num2Parametro)
        {
            decimal resultado;

            //Multiplicacion con los valores que mandaron los argumentos
            resultado = num1Parametro * num2Parametro;

            Console.WriteLine("{0} * {1} = {2}", num1Parametro, num2Parametro, resultado);
        }

        //4. Metodos con parametros y que devuelven un tipo
        static decimal Dividir(decimal num1Parametro1, decimal num2Parametro2)
        {
            decimal resultado;
            if (num2Parametro2 != 0)
            {
                resultado = num1Parametro1 / num2Parametro2;
            }
            else
            {
                Console.WriteLine("No es posible Dividir entre 0");
                resultado = 0;
            }

            return resultado;
        }

        static decimal IngresarNumero(string peticion)
        {
            //variable local al metodo

            decimal numero;

            Console.WriteLine(peticion);
            numero = Convert.ToDecimal(Console.ReadLine());
            return numero;
        }


        /*
         * 
         * 1. Metodos sin parametros ni tipo
         * 2. Metodos con parametros
         * 3. Metodos que devuelven un tipo
         * 4. Metodos con parametros y que devuelven un tipo
         * 
         * 
         */
    }
}
