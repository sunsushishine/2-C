using System;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как тебя зовут? - ");
            string name = Console.ReadLine();

            Console.Write("Сколько тебе лет? - ");
            int age = int.Parse(Console.ReadLine());

            int n_year = Convert.ToInt32(DateTime.Now.Year);
            int b_age = n_year - age;

            Console.Write(name + " ты родился в " + b_age + "году");
        }
    }
}
