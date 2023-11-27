using System;

class Employee
{
    private string surname;
    private string name;

    public Employee(string surname, string name)
    {
        this.surname = surname;
        this.name = name;
    }

    public void DisplayInfo(string position, int experience)
    {
        double baseSalary = 1000;


        if (position == "junior")
            baseSalary *= 1.3;
        else if (position == "senior")
            baseSalary *= 1.7;

        if (experience >= 5)
            baseSalary += 300;
        else if (experience >= 10)
            baseSalary += 700;

        double tax = baseSalary * 0.18;
        Console.WriteLine($"Прізвище: {surname}");
        Console.WriteLine($"Ім'я: {name}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {baseSalary}");
        Console.WriteLine($"Податковий збір: {tax}");
    }
}