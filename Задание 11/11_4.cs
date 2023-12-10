using System;
using System.Collections.Generic;

class Applicant
{
    public string FullName { get; set; }
    public double AverageScore { get; set; }

    public Applicant(string fullName, double averageScore)
    {
        FullName = fullName;
        AverageScore = averageScore;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ФИО: {FullName}, Средний балл: {AverageScore}");
    }
}

class Program
{
    static void Main()
    {
        List<Applicant> applicants = new List<Applicant>();
        double thresholdScore;
        int maxEnrollments = 4;

        Console.Write("Введите пороговое значение среднего балла для зачисления: ");
        while (!double.TryParse(Console.ReadLine(), out thresholdScore))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение.");
        }

        while (true)
        {
            Console.WriteLine("\nМеню программы:");
            Console.WriteLine("1. Регистрация абитуриентов");
            Console.WriteLine("2. Удаление забранных заявлений");
            Console.WriteLine("3. Зачисление абитуриентов (вывод всех зачисленных и выход из программы)");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Некорректный выбор. Пожалуйста, введите число от 1 до 3.");
            }

            switch (choice)
            {
                case 1:
                    RegisterApplicant(applicants);
                    break;
                case 2:
                    RemoveWithdrawnApplications(applicants);
                    break;
                case 3:
                    EnrollApplicants(applicants, thresholdScore, maxEnrollments);
                    return;
            }
        }
    }

    static void RegisterApplicant(List<Applicant> applicants)
    {
        Console.WriteLine("\nРегистрация нового абитуриента:");
        Console.Write("Введите ФИО абитуриента: ");
        string fullName = Console.ReadLine();

        double averageScore;
        while (true)
        {
            Console.Write("Введите средний балл абитуриента: ");
            if (double.TryParse(Console.ReadLine(), out averageScore))
            {
                break;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение.");
            }
        }

        applicants.Add(new Applicant(fullName, averageScore));
        Console.WriteLine("Абитуриент успешно зарегистрирован.");
    }

    static void RemoveWithdrawnApplications(List<Applicant> applicants)
    {
        Console.WriteLine("\nУдаление забранных заявлений:");
        Console.Write("Введите ФИО абитуриента, который забрал заявление: ");
        string withdrawnApplicantName = Console.ReadLine();

        for (int i = 0; i < applicants.Count; i++)
        {
            if (applicants[i].FullName.Equals(withdrawnApplicantName, StringComparison.OrdinalIgnoreCase))
            {
                applicants.RemoveAt(i);
                Console.WriteLine("Абитуриент успешно удален.");
                return;
            }
        }

        Console.WriteLine("Абитуриент с таким ФИО не найден.");
    }

    static void EnrollApplicants(List<Applicant> applicants, double thresholdScore, int maxEnrollments)
    {
        Console.WriteLine("\nЗачисление абитуриентов:");

        int enrollmentsCount = 0;

        foreach (var applicant in applicants)
        {
            if (applicant.AverageScore >= thresholdScore && enrollmentsCount < maxEnrollments)
            {
                applicant.DisplayInfo();
                enrollmentsCount++;
            }
        }

        if (enrollmentsCount == 0)
        {
            Console.WriteLine("Нет зачисленных абитуриентов.");
        }
    }
}
