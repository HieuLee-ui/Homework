using System;

class S2
{
    public static double CalculateS2(int n)
    {
        double result = 1;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            double term = Math.Pow(-2, i) / factorial;
            result += term;
        }

        return result;
    }
}

