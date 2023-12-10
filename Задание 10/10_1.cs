using System;
using System.Security.Cryptography;

// Интерфейс, представляющий фигуру
interface IFigure
{
    double Area();
    double Perimeter();
}

// Класс для круга, реализующий интерфейс IFigure
class Circle : IFigure
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

// Класс для квадрата, реализующий интерфейс IFigure
class Square : IFigure
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double Area()
    {
        return Math.Pow(side, 2);
    }

    public double Perimeter()
    {
        return 4 * side;
    }
}

// Класс для равностороннего треугольника, реализующий интерфейс IFigure
class Triangle : IFigure
{
    private double side;

    public Triangle(double side)
    {
        this.side = side;
    }

    public double Area()
    {
        return (Math.Sqrt(3) / 4) * Math.Pow(side, 2);
    }

    public double Perimeter()
    {
        return 3 * side;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите радиус круга: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(radius);
        Console.WriteLine($"Площадь круга: {circle.Area().ToString("F3")}, Периметр круга: {circle.Perimeter().ToString("F3")}");
        Console.WriteLine(" ");

        Console.Write("Введите длину стороны квадрата: ");
        double sideSquare = Convert.ToDouble(Console.ReadLine());
        Square square = new Square(sideSquare);
        Console.WriteLine($"Площадь квадрата: {square.Area().ToString("F3")}, Периметр квадрата: {square.Perimeter().ToString("F3")}");
        Console.WriteLine(" ");

        Console.Write("Введите длину стороны равностороннего треугольника: ");
        double sideTriangle = Convert.ToDouble(Console.ReadLine());
        Triangle triangle = new Triangle(sideTriangle);
        Console.WriteLine($"Площадь треугольника: {triangle.Area().ToString("F3")}, Периметр треугольника: {triangle.Perimeter().ToString("F3")}");
        Console.WriteLine(" ");
    }
}
