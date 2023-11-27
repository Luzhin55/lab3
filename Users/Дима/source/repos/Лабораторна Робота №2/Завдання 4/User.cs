using System;

class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        registrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("Login: " + login);
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Registration Date: " + registrationDate.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}