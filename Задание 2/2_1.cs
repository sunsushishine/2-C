using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите признак транспортного средства (а - автомобиль, в - велосипед, м - мотоцикл, с - самолет, п - поезд): ");
        char symbol = Convert.ToChar(Console.ReadLine());

        switch (symbol)
        {
            case 'а':
                Console.WriteLine("Максимальная скорость автомобиля: 180 км/ч");
                break;
            case 'в':
                Console.WriteLine("Максимальная скорость велосипеда: 30 км/ч");
                break;
            case 'м':
                Console.WriteLine("Максимальная скорость мотоцикла: 120 км/ч");
                break;
            case 'с':
                Console.WriteLine("Максимальная скорость самолета: 900 км/ч");
                break;
            case 'п':
                Console.WriteLine("Максимальная скорость поезда: 220 км/ч");
                break;
            default:
                Console.WriteLine("Неверный признак транспортного средства");
                break;
        }
    }
}
