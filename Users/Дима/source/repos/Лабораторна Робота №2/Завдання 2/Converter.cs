using System;

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertToUSD(double amount)
    {
        return amount / usdRate;
    }

    public double ConvertToEUR(double amount)
    {
        return amount / eurRate;
    }

    public double ConvertToPLN(double amount)
    {
        return amount / plnRate;
    }

    public double ConvertFromUSD(double amount)
    {
        return amount * usdRate;
    }

    public double ConvertFromEUR(double amount)
    {
        return amount * eurRate;
    }

    public double ConvertFromPLN(double amount)
    {
        return amount * plnRate;
    }
}
