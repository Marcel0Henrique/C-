using System;

namespace AT1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "estou estudando c#";
            string[] array = texto.Split(" ");
            Console.WriteLine(array[1]);
        }
    }
}
