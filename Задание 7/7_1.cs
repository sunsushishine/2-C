using System;
using System.Globalization;

class Book
{
    // Поля класса Book
    private string title;
    private string author;
    private decimal price;

    // Конструктор класса Book
    public Book(string title, string author, decimal price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Свойства get/set для доступа к полям класса Book
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    // Метод Print() для вывода информации о книге
    public virtual void Print()
    {
        Console.WriteLine($"Название: {title}");
        Console.WriteLine($"Автор: {author}");
        Console.WriteLine($"Стоимость: {price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
    }
}

class BookGenre : Book
{
    // Дополнительное поле для класса BookGenre
    private string genre;

    // Конструктор класса BookGenre
    public BookGenre(string title, string author, decimal price, string genre)
        : base(title, author, price)
    {
        this.genre = genre;
    }

    // Свойство get/set для доступа к полю класса BookGenre
    public string Genre
    {
        get { return genre; }
        set { genre = value; }
    }

    // Переопределенный метод Print() для вывода информации о книге с учетом жанра
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Жанр: {genre}");
    }
}

class BookGenrePubl : BookGenre
{
    // Дополнительное поле для класса BookGenrePubl
    private string publisher;

    // Конструктор класса BookGenrePubl
    public BookGenrePubl(string title, string author, decimal price, string genre, string publisher)
        : base(title, author, price, genre)
    {
        this.publisher = publisher;
    }

    // Свойство get/set для доступа к полю класса BookGenrePubl
    public string Publisher
    {
        get { return publisher; }
        set { publisher = value; }
    }

    // Переопределенный метод Print() для вывода информации о книге с учетом издателя
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Издатель: {publisher}");
    }
}

class Program
{
    static void Main()
    {
        // Пример использования классов
        BookGenrePubl book = new BookGenrePubl("Война и мир", "Лев Толстой", 25.99m, "Роман", "Издательство А");
        book.Print();

        BookGenrePubl book_1 = new BookGenrePubl("Король в желтом", "Роберт Чамберс", 20.10m, "Ужасы", "Издательство B");
        book_1.Print();
    }
}
