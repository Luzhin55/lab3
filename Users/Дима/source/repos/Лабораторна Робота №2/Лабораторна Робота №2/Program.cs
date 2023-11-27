using System;

class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address();

        myAddress.Index = "12345";
        myAddress.Country = "Україна";
        myAddress.City = "Полтава";
        myAddress.Street = "Вулиця Небесної Сотні";
        myAddress.House = "61";
        myAddress.Apartment = "25";

        Console.WriteLine("Index: " + myAddress.Index);
        Console.WriteLine("Country: " + myAddress.Country);
        Console.WriteLine("City: " + myAddress.City);
        Console.WriteLine("Street: " + myAddress.Street);
        Console.WriteLine("House: " + myAddress.House);
        Console.WriteLine("Apartment: " + myAddress.Apartment);
    }
}