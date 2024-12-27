using System;

class S1
{
    public static double CalculateS1(int n)
    {
        double result = 0;
        int sumOfSquares = 0;

        for (int i = 1; i <= n; i++)
        {
            sumOfSquares += i * i;
            int sign = (i % 2 == 0) ? -1 : 1;
            double term = sign / (double)sumOfSquares;
            result += term;
        }

        return result;
    }
}


//dua code len github, tao file word(dua cac đường link github), để private mode nhưng phải để share cho thầy, thangngt.cntt@gmail.com, 1 solution có thể có nhiều prj, ứng vs mỗi bài toán cbi 1 bộ dữ liệu test(4-5 dl thử nghiệm, vd x =, tinhtay=, tinhmay=, passed)
