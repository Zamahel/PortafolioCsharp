using System;

namespace operadoresIncrementoDecremento
{
    class Program
    {
        static void Main(string[] args)
        {
            int incremento;

            incremento = 10;

            Console.WriteLine("Valor con incremento incluido: {0}", incremento++);

            //ya no incrementamos, solo imprimimos

            Console.WriteLine(incremento);
        }
    }
}
