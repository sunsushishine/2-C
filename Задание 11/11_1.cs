using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Console.Write("Введите размерность массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        ArrayList arrayList = new ArrayList();

        // Заполнение массива случайными числами
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            arrayList.Add(random.Next(100)); // Здесь 100 - максимальное значение для случайного числа
        }

        // Вывод массива
        Console.WriteLine("Массив:");
        PrintArrayList(arrayList);

        // Нахождение номера первого максимального элемента
        int maxIndex = FindFirstMaxIndex(arrayList);

        // Вывод результата
        Console.WriteLine($"Номер первого максимального элемента: {maxIndex}");
    }

    // Метод для вывода элементов ArrayList
    static void PrintArrayList(ArrayList arrayList)
    {
        foreach (var item in arrayList)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    // Метод для нахождения номера первого максимального элемента в ArrayList
    static int FindFirstMaxIndex(ArrayList arrayList)
    {
        if (arrayList.Count == 0)
        {
            Console.WriteLine("Массив пуст.");
            return -1;
        }

        int maxIndex = 0;
        for (int i = 1; i < arrayList.Count; i++)
        {
            if ((int)arrayList[i] > (int)arrayList[maxIndex])
            {
                maxIndex = i;
            }
        }

        return maxIndex;
    }
}
