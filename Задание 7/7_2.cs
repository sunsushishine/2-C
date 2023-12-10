using System;

// Базовый класс, представляющий общие характеристики фигуры
class Figure
{
    protected double perimeter; // Периметр фигуры
    protected double area;      // Площадь фигуры

    public double Perimeter
    {
        get { return perimeter; }
    }

    public double Area
    {
        get { return area; }
    }
}

// Класс, представляющий окружность, наследуемый от базового класса Figure
class Circle : Figure
{
    private double radius; // Радиус окружности

    // Конструктор класса Circle
    public Circle(double radius)
    {
        this.radius = radius;
        CalculatePerimeter();
        CalculateArea();
    }

    // Метод для вычисления периметра окружности
    private void CalculatePerimeter()
    {
        perimeter = 2 * Math.PI * radius;
    }

    // Метод для вычисления площади окружности
    private void CalculateArea()
    {
        area = Math.PI * Math.Pow(radius, 2);
    }
}

// Класс, представляющий прямоугольник, наследуемый от базового класса Figure
class Rectangle : Figure
{
    private double sideA; // Сторона A прямоугольника
    private double sideB; // Сторона B прямоугольника

    // Конструктор класса Rectangle
    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        CalculatePerimeter();
        CalculateArea();
    }

    // Метод для вычисления периметра прямоугольника
    private void CalculatePerimeter()
    {
        perimeter = 2 * (sideA + sideB);
    }

    // Метод для вычисления площади прямоугольника
    private void CalculateArea()
    {
        area = sideA * sideB;
    }
}

// Класс, представляющий треугольник, наследуемый от базового класса Figure
class Triangle : Figure
{
    private double sideA; // Сторона A треугольника
    private double sideB; // Сторона B треугольника
    private double sideC; // Сторона C треугольника

    // Конструктор класса Triangle
    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
        CalculatePerimeter();
        CalculateArea();
    }

    // Метод для вычисления периметра треугольника
    private void CalculatePerimeter()
    {
        perimeter = sideA + sideB + sideC;
    }

    // Метод для вычисления площади треугольника
    private void CalculateArea()
    {
        double p = perimeter / 2;
        area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }
}

// Класс для запуска программы
class Program
{
    // Метод Main, с которого начинается выполнение программы
    static void Main()
    {
        Console.WriteLine("Введите радиус окружности:");
        double radiusCircle = Convert.ToDouble(Console.ReadLine());

        // Создание объекта класса Circle и вычисление периметра и площади
        Circle circle = new Circle(radiusCircle);
        Console.WriteLine($"Окружность: Периметр = {circle.Perimeter}, Площадь = {circle.Area}");

        Console.WriteLine("Введите стороны прямоугольника:");
        Console.Write("Сторона A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        // Создание объекта класса Rectangle и вычисление периметра и площади
        Rectangle rectangle = new Rectangle(sideA, sideB);
        Console.WriteLine($"Прямоугольник: Периметр = {rectangle.Perimeter}, Площадь = {rectangle.Area}");

        Console.WriteLine("Введите стороны треугольника:");
        Console.Write("Сторона A: ");
        double sideATriangle = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона B: ");
        double sideBTriangle = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона C: ");
        double sideCTriangle = Convert.ToDouble(Console.ReadLine());

        // Создание объекта класса Triangle и вычисление периметра и площади
        Triangle triangle = new Triangle(sideATriangle, sideBTriangle, sideCTriangle);
        Console.WriteLine($"Треугольник: Периметр = {triangle.Perimeter}, Площадь = {triangle.Area}");
    }
}
