namespace Test.Task_05;

public class MyMath
{
    public static double PowerOf(int number, int power)
    {
        if (power == 0) return 1;

        double result = number;

        int p = power > 0 ? power : -power;

        for (var i = 1; i < p; i++)
        {
            result *= number;
        }

        return power > 0 ? result : 1 / result;
    }

    public static int Fac(int number)
    {
        var fac = number;
        
        for (var i = 1; i < number; i++)
        {
            fac *= i;
        }

        return fac;
    }
}