using System;

class Visa
{
    protected string clientName;
    protected string accountNumber;
    protected decimal currentBalance;

    public Visa(string clientName, string accountNumber, decimal initialBalance)
    {
        this.clientName = clientName;
        this.accountNumber = accountNumber;
        this.currentBalance = initialBalance;
    }

    public void CreateAccount(string clientName, string accountNumber, decimal initialBalance)
    {
        this.clientName = clientName;
        this.accountNumber = accountNumber;
        this.currentBalance = initialBalance;
    }

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

    public virtual void Withdraw(decimal amount)
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

    public virtual void PrintAccountStatus()
    {
        Console.WriteLine($"Имя клиента: {clientName}");
        Console.WriteLine($"Номер счета: {accountNumber}");
        Console.WriteLine($"Текущий баланс: {currentBalance:C}");
    }
}

class VisaPlus : Visa
{
    private decimal maxOverdraft;
    private decimal interestRate;
    private decimal currentOverdraft;

    public VisaPlus(string clientName, string accountNumber, decimal initialBalance, decimal maxOverdraft, decimal interestRate)
        : base(clientName, accountNumber, initialBalance)
    {
        this.maxOverdraft = maxOverdraft;
        this.interestRate = interestRate;
        this.currentOverdraft = 0;
    }

    public override void Withdraw(decimal amount)
    {
        decimal totalBalance = currentBalance + currentOverdraft;

        if (amount > 0 && amount <= totalBalance)
        {
            if (amount <= currentBalance)
            {
                currentBalance -= amount;
            }
            else
            {
                decimal overdraftUsed = amount - currentBalance;
                currentBalance = 0;
                currentOverdraft -= overdraftUsed;
            }

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

    public override void PrintAccountStatus()
    {
        base.PrintAccountStatus();
        Console.WriteLine($"Максимальный овердрафт: {maxOverdraft:C}");
        Console.WriteLine($"Процентная ставка на овердрафт: {interestRate:P}");
        Console.WriteLine($"Текущий овердрафт: {currentOverdraft:C}");
    }
}

class Program
{
    static void Main()
    {
        VisaPlus visaPlusAccount = new VisaPlus("Иванов Иван", "123456789", 1000.00m, 500.00m, 0.05m);

        Console.WriteLine("Начальное состояние счета VisaPlus:");
        visaPlusAccount.PrintAccountStatus();
        Console.WriteLine();

        visaPlusAccount.Deposit(500.50m);
        visaPlusAccount.Withdraw(2000.00m);
        visaPlusAccount.Withdraw(800.00m);
        Console.WriteLine();

        Console.WriteLine("Обновленное состояние счета VisaPlus:");
        visaPlusAccount.PrintAccountStatus();
    }
}
