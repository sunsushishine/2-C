using System;
using System.Collections.Generic;

class Client
{
    public string Name { get; set; }
    public decimal MaxCredit { get; set; }
    public decimal InterestRate { get; set; }

    public Client(string name, decimal maxCredit, decimal interestRate)
    {
        Name = name;
        MaxCredit = maxCredit;
        InterestRate = interestRate;
    }

    public decimal CalculateMaxCredit()
    {
        return MaxCredit * (1 + InterestRate / 100);
    }
}

class Program
{
    static void Main()
    {
        List<Client> clients = new List<Client>
        {
            new Client("Клиент 1", 500, 18.5m),
            new Client("Клиент 2", 1000, 22.5m),
            // Добавьте сюда других клиентов, если необходимо
        };

        Console.WriteLine("Расчет максимального кредита для клиентов:");
        Console.WriteLine();

        foreach (var client in clients)
        {
            decimal maxCredit = client.CalculateMaxCredit();
            Console.WriteLine($"{client.Name}: Максимальный кредит: {maxCredit:C}");
        }
    }
}
