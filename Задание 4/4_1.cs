using System;

class Program
{
    static void Main()
    {
        // Инициализируем последовательность целых чисел
        int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 18, 27, 36, 45 };

        // Инициализируем сумму
        int sum = 0;

        // Проходим по последовательности
        foreach (int number in sequence)
        {
            // Проверяем, делится ли число на 9
            if (number % 9 == 0)
            {
                // Добавляем число к сумме
                sum += number;
            }
        }

        // Выводим сумму
        Console.WriteLine("Сумма элементов, кратных 9, равна: " + sum);
    }
}
