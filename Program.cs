using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        var input = Console.ReadLine();
        int n = int.Parse(input);

        Console.WriteLine($"S1 = {S1.CalculateS1(n)}");
        Console.WriteLine($"S2 = {S2.CalculateS2(n)}");
        Console.WriteLine($"S5 = {S5.CalculateS5(n)}");
        Console.WriteLine($"S5 = {S6.CalculateS6(n)}");
    }
}

