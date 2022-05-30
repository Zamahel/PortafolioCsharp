using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int i, j, resultado;

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tabla de multiplicar del {0}", i);//Nos muestra la tabla actual
                for (j = 1; j <= 10; j++)
                {
                    resultado = i * j;
                    Console.WriteLine("{0} * {1} = {2}", i, j, resultado);
                }
            }
        }
    }
}
