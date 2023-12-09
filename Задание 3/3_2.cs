using System;

class Program
{
    static long Power(long x, long n)
    {
        if (n == 0)
            return 1;
        else if (n % 2 == 0)
            return Power(x * x, n / 2);
        else
            return x * Power(x, n - 1);
    }

    static void Main(string[] args)
    {
        // a)
        Console.WriteLine("Метод a:");
        Console.Write("Введите a: ");
        long a = Convert.ToInt64(Console.ReadLine());
        Console.Write("Введите b: ");
        long b = Convert.ToInt64(Console.ReadLine());
        Console.Write("Введите h: ");
        long h = Convert.ToInt64(Console.ReadLine());

        for (long x = a; x <= b; x += h)
        {
            long n = x - a + 1;
            Console.WriteLine($"{x}^{n} = {Power(x, n)}");
        }

        Console.WriteLine("Нажмите любую клавишу для выполнения следующего метода...");
        Console.ReadKey();

        // б)
        Console.WriteLine("Метод б:");
        Console.Write("Введите a: ");
        a = Convert.ToInt64(Console.ReadLine());
        Console.Write("Введите b: ");
        b = Convert.ToInt64(Console.ReadLine());
        Console.Write("Введите h: ");
        h = Convert.ToInt64(Console.ReadLine());

        long sum = 0;

        for (long x = a; x <= b; x += h)
        {
            long n = x - a + 1;
            sum += Power(x, n);
        }
        Console.WriteLine($"Сумма: {sum}");

        Console.WriteLine("Нажмите любую клавишу для выполнения следующего метода...");
        Console.ReadKey();

        // в)
        Console.WriteLine("Метод в:");
        Console.Write("Введите a: ");
        a = Convert.ToInt64(Console.ReadLine());
        Console.Write("Введите b: ");
        b = Convert.ToInt64(Console.ReadLine());


        for (long x = a; x <= b; x++)
        {
            for (long y = x + 1; y <= b; y++)
            {
                for (long z = y + 1; z <= b; z++)
                {
                    if (Power(x, 2) + Power(y, 2) == Power(z, 2))
                        Console.WriteLine($"{x}, {y}, {z}");
                }
            }
        }

        Console.WriteLine("Нажмите любую клавишу для выполнения следующего метода...");
        Console.ReadKey();

        // г)
        Console.WriteLine("Метод г:");
        Console.Write("Введите a: ");
        a = Convert.ToInt64(Console.ReadLine());
        long n2 = 0;
        while (2 * n2 - 1 <= a)
            n2++;

        Console.WriteLine($"n = {n2 - 1}");
    }
}
