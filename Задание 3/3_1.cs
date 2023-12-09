using System;

class Program
{
        public static int f(int x)
        {
            if (x % 2 == 0)
            {
                return x / 2;
            }
            else
            {
                return 0;
            }
        }

        public static void Main(string[] args)
        {
            while (true)
            {
            Console.Write("Введите число (или 'q' для выхода): ");
            string input = Console.ReadLine();

                if (input.ToLower() == "q")    
                {
                    break;
                }
            
            int x = Convert.ToInt32(input);
            Console.WriteLine("Результат: " + f(x));
            }
        }
    }
