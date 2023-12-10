using System;

class Human
{
    // Поля базового класса Human
    private string lastName;
    private string address;
    private string phoneNumber;
    private int birthYear;

    // Конструктор класса Human
    public Human(string lastName, string address, string phoneNumber, int birthYear)
    {
        this.lastName = lastName;
        this.address = address;
        this.phoneNumber = phoneNumber;
        this.birthYear = birthYear;
    }

    // Свойства get/set для доступа к полям класса Human
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public int BirthYear
    {
        get { return birthYear; }
        set { birthYear = value; }
    }

    // Метод для вывода информации о содержимом полей класса Human
    public void Print()
    {
        Console.WriteLine($"Фамилия: {lastName}");
        Console.WriteLine($"Адрес: {address}");
        Console.WriteLine($"Телефон: {phoneNumber}");
        Console.WriteLine($"Год рождения: {birthYear}");
    }
}

class Student : Human
{
    // Дополнительные поля класса Student
    private string group;
    private int course;
    private string studentId;

    // Конструктор класса Student с использованием base для вызова конструктора родительского класса Human
    public Student(string lastName, string address, string phoneNumber, int birthYear, string group, int course, string studentId)
        : base(lastName, address, phoneNumber, birthYear)
    {
        this.group = group;
        this.course = course;
        this.studentId = studentId;
    }

    // Свойства get/set для доступа к полям класса Student
    public string Group
    {
        get { return group; }
        set { group = value; }
    }

    public int Course
    {
        get { return course; }
        set { course = value; }
    }

    public string StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }

    // Переопределение метода Print для класса Student
    public new void Print()
    {
        base.Print(); // Вызов метода Print родительского класса Human
        Console.WriteLine($"Группа: {group}");
        Console.WriteLine($"Курс: {course}");
        Console.WriteLine($"Номер зачетной книги: {studentId}");
    }
}

class Program
{
    static void Main()
    {
        // Пример использования классов Human и Student
        Human human = new Human("Иванов", "Москва", "123-456-789", 1990);
        Console.WriteLine("Информация о человеке:");
        human.Print();
        Console.WriteLine();

        Student student = new Student("Петров", "Санкт-Петербург", "987-654-321", 1995, "Группа123", 2, "123456");
        Console.WriteLine("Информация о студенте:");
        student.Print();
    }
}
