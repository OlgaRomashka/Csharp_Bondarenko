namespace Test.Task_05;

public class MyMath
{
    public static double PowerOf(double number, int power)
    {
        if (power == 0) return 1;

        var result = number;

        var p = power > 0 ? power : -power;

        for (var i = 1; i < p; i++)
        {
            result *= number;
        }

        return power > 0 ? result : 1 / result;
    }

    public static double Fac(int number)
    {
        return number == 1 ? 1 : number * Fac(number - 1);
    }
}