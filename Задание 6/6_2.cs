using System;

class Visa
{
    // Поля базового класса Visa
    private string clientName;
    private string accountNumber;
    private decimal currentBalance;

    // Конструктор класса Visa
    public Visa(string clientName, string accountNumber, decimal initialBalance)
    {
        this.clientName = clientName;
        this.accountNumber = accountNumber;
        this.currentBalance = initialBalance;
    }

    // Метод для создания счета
    public void CreateAccount(string clientName, string accountNumber, decimal initialBalance)
    {
        this.clientName = clientName;
        this.accountNumber = accountNumber;
        this.currentBalance = initialBalance;
    }

    // Метод для внесения денег на счет
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            currentBalance += amount;
            Console.WriteLine($"Деньги внесены на счет. Новый баланс: {currentBalance:C}");
        }
        else
        {
            Console.WriteLine("Сумма для внесения должна быть положительной.");
        }
    }

    // Метод для снятия денег со счета
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= currentBalance)
        {
            currentBalance -= amount;
            Console.WriteLine($"Средства сняты со счета. Новый баланс: {currentBalance:C}");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Сумма для снятия должна быть положительной.");
        }
        else
        {
            Console.WriteLine("Недостаточно средств на счете.");
        }
    }

    // Метод для вывода состояния счета
    public void PrintAccountStatus()
    {
        Console.WriteLine($"Имя клиента: {clientName}");
        Console.WriteLine($"Номер счета: {accountNumber}");
        Console.WriteLine($"Текущий баланс: {currentBalance:C}");
    }
}

class Program
{
    static void Main()
    {
        // Пример использования класса Visa
        Visa visaAccount = new Visa("Иванов Иван", "123456789", 1000.00m);

        // Вывод начального состояния счета
        Console.WriteLine("Начальное состояние счета:");
        visaAccount.PrintAccountStatus();
        Console.WriteLine();

        // Внесение и снятие денег
        visaAccount.Deposit(500.50m);
        visaAccount.Withdraw(200.75m);
        Console.WriteLine();

        // Вывод обновленного состояния счета
        Console.WriteLine("Обновленное состояние счета:");
        visaAccount.PrintAccountStatus();
    }
}
