using System;
//Problem 14: Currency Converter
class CurrencyConverter
{
    static void Main(string[] args)
    {
        double amount = double.Parse(Console.ReadLine());
        string currencyOne = Console.ReadLine();
        string currencyTwo = Console.ReadLine();
        double convertionOne = new double();
        double convertionTwo = new double();
        double BGN = 1;
        double USD = 1.79549;
        double EUR = 1.95583;
        double GBP = 2.53405;
        switch (currencyOne)
        {
            case "BGN":
                convertionOne = amount * BGN;
                break;
            case "USD":
                convertionOne = amount * USD;
                break;
            case "EUR":
                convertionOne = amount * EUR;
                break;
            case "GBP":
                convertionOne = amount * GBP;
                break;
        }
        switch (currencyTwo)
        {
            case "BGN":
                convertionTwo = convertionOne / BGN;
                break;
            case "USD":
                convertionTwo = convertionOne / USD;
                break;
            case "EUR":
                convertionTwo = convertionOne / EUR;
                break;
            case "GBP":
                convertionTwo = convertionOne / GBP;
                break;
        }
        Console.WriteLine(Math.Round(convertionTwo, 2));
    }
}
