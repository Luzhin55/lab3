using System;

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter(35.98, 39.34, 9);

        double amountInUah = 10000;

        Console.WriteLine($"10000 UAH в USD: {converter.ConvertToUSD(amountInUah)}");
        Console.WriteLine($"10000 UAH в EUR: {converter.ConvertToEUR(amountInUah)}");
        Console.WriteLine($"10000 UAH в PLN: {converter.ConvertToPLN(amountInUah)}");

        double amountInCurrency = 1000;

        Console.WriteLine($"1000 USD в UAH: {converter.ConvertFromUSD(amountInCurrency)}");
        Console.WriteLine($"1000 EUR в UAH: {converter.ConvertFromEUR(amountInCurrency)}");
        Console.WriteLine($"1000 PLN в UAH: {converter.ConvertFromPLN(amountInCurrency)}");
    }
}