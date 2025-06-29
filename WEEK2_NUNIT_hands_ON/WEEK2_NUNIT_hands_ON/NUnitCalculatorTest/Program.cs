
using System;
using CalcLibrary;

class Program
{
    static void Main()
    {
        var calc = new Calculator();

        Console.WriteLine("=== Simulated NUnit Test ===");

        int result = calc.Add(2, 3);
        Console.WriteLine($"Test Add(2, 3): Expected 5, Got {result} => {(result == 5 ? "PASS" : "FAIL")}");

        result = calc.Add(10, 20);
        Console.WriteLine($"Test Add(10, 20): Expected 30, Got {result} => {(result == 30 ? "PASS" : "FAIL")}");

        result = calc.Add(-1, 1);
        Console.WriteLine($"Test Add(-1, 1): Expected 0, Got {result} => {(result == 0 ? "PASS" : "FAIL")}");
    }
}
