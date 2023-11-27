using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть довжину першої сторони прямокутника:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину другої сторони прямокутника:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
    }
}

