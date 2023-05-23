namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount;
            string fromCurrency, toCurrency;
            double convertedAmount;

            Console.WriteLine("Welcome to Currency Converter");
            Console.WriteLine("Supported currencies: PLN, EUR, GBP, USD");

            Console.Write("Enter the amount to convert: ");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the currency to convert from: ");
            fromCurrency = Console.ReadLine().ToUpper();

            Console.Write("Enter the currency to convert to: ");
            toCurrency = Console.ReadLine().ToUpper();

            switch (fromCurrency)
            {
                case "PLN":
                    convertedAmount = amount / 3.92;
                    break;
                case "EUR":
                    convertedAmount = amount * 1.18;
                    break;
                case "GBP":
                    convertedAmount = amount * 1.38;
                    break;
                case "USD":
                    convertedAmount = amount * 0.93;
                    break;
                default:
                    Console.WriteLine("Invalid currency. Exiting program.");
                    return;
            }

            switch (toCurrency)
            {
                case "PLN":
                    convertedAmount *= 3.92;
                    break;
                case "EUR":
                    convertedAmount /= 1.18;
                    break;
                case "GBP":
                    convertedAmount /= 1.38;
                    break;
                case "USD":
                    convertedAmount /= 0.93;
                    break;
                default:
                    Console.WriteLine("Invalid currency. Exiting program.");
                    return;
            }

            Console.WriteLine("Converted amount: " + convertedAmount.ToString("0.00") + " " + toCurrency);
        }
    }
}