using System;

class Program
{
    static void Main(string[] args)
    {
        Point A = new Point(1, 1, "A");
        Point B = new Point(2, 4, "B");
        Point C = new Point(5, 3, "C");

        Figure triangle = new Figure(A, B, C);
        triangle.CalculatePerimeter();
    }
}