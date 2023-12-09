using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите А: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите B: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a % 2 == 0)
        {
            a++;
        }

        for (int i = a; i <= b; i += 2)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
