using System;

class Program
{
    static decimal f(decimal x)
    {
        if (x + 2 <= 1)
        {
            return x * x;
        }
        else if (1 < x + 2 && x + 2 < 10)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите a: ");
        decimal a = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите b: ");
        decimal b = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите h: ");
        decimal h = Convert.ToDecimal(Console.ReadLine());

        for (decimal x = a; x <= b; x += h)
        {
            Console.WriteLine("x = " + x + ", y = " + f(x));
        }
    }
}
