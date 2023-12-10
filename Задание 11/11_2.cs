using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> teamPlayers = new List<string>();

        while (true)
        {
            // Выводим текущий список игроков
            Console.WriteLine("Текущий список игроков команды:");
            PrintPlayerList(teamPlayers);

            // Запрашиваем фамилию нового игрока
            Console.Write("Введите фамилию нового игрока (или 'exit' для выхода): ");
            string newPlayer = Console.ReadLine();

            // Проверяем, если пользователь ввел "exit", завершаем программу
            if (newPlayer.ToLower() == "exit")
            {
                break;
            }

            // Добавляем нового игрока в список и сортируем
            AddPlayerToTeam(teamPlayers, newPlayer);
        }
    }

    // Метод для вывода списка игроков
    static void PrintPlayerList(List<string> players)
    {
        foreach (string player in players)
        {
            Console.WriteLine(player);
        }
        Console.WriteLine();
    }

    // Метод для добавления игрока в список и сортировки списка по алфавиту
    static void AddPlayerToTeam(List<string> teamPlayers, string newPlayer)
    {
        int index = teamPlayers.BinarySearch(newPlayer);

        if (index < 0)
        {
            teamPlayers.Insert(~index, newPlayer);
            Console.WriteLine($"Игрок {newPlayer} добавлен в команду.");
        }
        else
        {
            Console.WriteLine($"Игрок {newPlayer} уже находится в команде.");
        }
    }
}
