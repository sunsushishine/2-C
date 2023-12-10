using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x == 2)
            {
                Console.WriteLine("Ошибка: X не может быть равен 2 -> log(0)");
                return;
            }

            double y = Math.Log(Math.Abs(x - 2));

            Console.WriteLine("y = " + y);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода: введите число в правильном формате.");
        }
    }
}
