using System;

class Program
{
    static void Main()
    {
        // Инициализируем последовательность действительных чисел
        double[] sequence = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.10, 11.11, 12.12, 18.18, 27.27, 36.36, 45.45};

        // Инициализируем максимальное число и его индекс
        double maxNumber = double.MinValue;
        int maxIndex = -1;

        // Проходим по последовательности
        for (int i = 0; i < sequence.Length; i++)
        {
            // Если текущее число больше максимального, обновляем максимальное число и его индекс
            if (sequence[i] > maxNumber)
            {
                maxNumber = sequence[i];
                maxIndex = i;
            }
        }

        // Выводим индекс максимального числа
        Console.WriteLine("Индекс первого максимального элемента: " + maxIndex);
    }
}
