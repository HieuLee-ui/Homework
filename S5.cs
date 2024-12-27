using System;

class S5
{
    public static double CalculateS5(int n)
    {
        double result = 0;

        for (int i = 1; i <= n; i++)
        {
            double term = 1.0 / (2 * i); // Calculate the term
            if (i % 2 == 0)
                result -= term; // Subtract for even terms
            else
                result += term; // Add for odd terms
        }

        return result;
    }
}