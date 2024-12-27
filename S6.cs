using System;

class S6
{
    public static double CalculateS6(int n)
    {
        double result = 1; 
        int sum = 0;      

        for (int i = 2; i <= n; i++)
        {
            sum += i; 
            double term = 1.0 / sum; 

            if (i % 2 == 0) 
                result -= term;
            else 
                result += term;
        }

        return result;
    }
}
