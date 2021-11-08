using System;

namespace AT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"soma: {n1 + 2}");
        }
    }
}
