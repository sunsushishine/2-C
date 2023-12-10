using System.Drawing;

class Account
{
    public delegate void AccountStateHandler(string message);

    AccountStateHandler _del;


    public void RegisterHandler(AccountStateHandler del)
    {
        _del += del;
    }


    public void UnregisterHandler(AccountStateHandler del)
    {
        _del -= del;
    }

    int _sum;


    public Account(int sum)
    {
        _sum = sum;
    }

    public int CurrentSum
    {
        get { return _sum; }
    }
    public void Put(int sum)
    {
        sum += sum;
    }

    public void Withdraw(int sum)
    {
        if (sum <= _sum)
        {
            _sum -= sum;
            if (_del != null)
                _del($"Сумма {sum} снята со счета");
        }
        else
        {
            if (_del != null)
                Console.ForegroundColor = ConsoleColor.Red;
            _del("Недостаточно денег на счете");
            Console.ResetColor();
        }
    }
}
class Program
{
    static void Main()
    {
        Account account = new Account(200);
        Account.AccountStateHandler colorDelegate = new Account.AccountStateHandler(Color_Message);
        Account.AccountStateHandler bwDelegate = new Account.AccountStateHandler(Show_Message);

        account.RegisterHandler(bwDelegate);
        account.RegisterHandler(colorDelegate);
        account.UnregisterHandler(bwDelegate);
        account.UnregisterHandler(colorDelegate);
        account.RegisterHandler(bwDelegate);

        account.Withdraw(100);
        account.Withdraw(50);
        account.Withdraw(20);
        account.Withdraw(20);
        account.Withdraw(2000);
    }
    private static void Show_Message(String message)
    {
        Console.WriteLine(message);
    }

    private static void Color_Message(string message)
    {
        Console.WriteLine(message); 
    }
}
