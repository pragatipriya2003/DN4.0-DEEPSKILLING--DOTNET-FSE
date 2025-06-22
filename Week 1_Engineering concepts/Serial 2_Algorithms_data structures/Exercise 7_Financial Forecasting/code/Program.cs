using System;

class FinancialForecast
{
    // Method to calculate future investment value using compound interest
    public static double CalculateForecast(double principal, double annualRate, int years)
    {
        return principal * Math.Pow(1 + annualRate / 100, years);
    }

    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter initial investment amount (₹): ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter expected annual growth rate (%): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number of years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        // Calculate forecast
        double futureValue = CalculateForecast(principal, rate, years);

        // Display result
        Console.WriteLine($"\nYour investment of ₹{principal:N2} will grow to ₹{futureValue:N2} in {years} years at {rate}% annual growth rate.");
    }
}