using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("V - ");
            double V = double.Parse(Console.ReadLine());
            Console.WriteLine("а - " + Math.Pow(V, 1 / 3.0));
        }
    }
}
