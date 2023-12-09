using System;

class Akcii
{
    private string company;
    private long kol_akcii;
    private double cena_akcii;
    private double total_val;

    public void pokupka_nach(string company, long kol_akcii, double cena_akcii)
    {
        this.company = company;
        this.kol_akcii = kol_akcii;
        this.cena_akcii = cena_akcii;
        set_tot();
    }

    public void pokupka_dop(long num, double price)
    {
        kol_akcii += num;
        cena_akcii = price;
        set_tot();
        Console.WriteLine($"Покупка дополнительного пакета ({num} акций по цене {price}) {company}");
        Console.WriteLine();
    }

    public void sell(long num, double price)
    {
        if (num > kol_akcii)
        {
            Console.WriteLine("Попытка продать больше акций чем есть.");
            Console.WriteLine("Нельзя продать не хватает акций");
            Console.WriteLine();
            return;
        }

        kol_akcii -= num;
        cena_akcii = price;
        set_tot();
        Console.WriteLine($"Продажа пакета ({num} акций по цене {price}) {company}");
    }

    public void show()
    {
        Console.WriteLine($"Компания: {company}");
        Console.WriteLine($"Кол-во: {kol_akcii}");
        Console.WriteLine($"Цена акции: {cena_akcii}");
        Console.WriteLine($"Стоимость всего пакета: {total_val}");
        Console.WriteLine();
    }

    private void set_tot()
    {
        total_val = cena_akcii * kol_akcii;
    }
}

class Program
{
    static void Main()
    {
        Akcii akcii = new Akcii();
        akcii.pokupka_nach("BeeLine", 20, 12.5);
        akcii.show();

        akcii.pokupka_dop(20, 18.0);
        akcii.show();

        akcii.sell(100, 18.0);
        akcii.show();

        akcii.pokupka_dop(30, 40.5);
        akcii.show();

        akcii.sell(40, 30.5);
        akcii.show();
    }
}
