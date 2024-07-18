namespace Test.Task_05;

public class Task05
{
    public static void Execute()
    {
        ConsoleKey operation;

        do
        {
            Console.WriteLine();
            Console.Write("Choose an operation: P - POWER, F - FACTORIAL: ");
            operation = Console.ReadKey().Key;
        } while (operation != ConsoleKey.P && operation != ConsoleKey.F);

        Console.WriteLine();

        try
        {
            switch (operation)
            {
                case ConsoleKey.P:
                    Console.Clear();
                    var n = AskForInt("Please, enter the NUMBER: ");
                    var p = AskForInt("Please, enter the POWER: ");
                    var r1 = MyMath.PowerOf(n, p);
                    Console.WriteLine($"RESULT: {r1}");
                    break;
                case ConsoleKey.F:
                    Console.Clear();
                    var f = AskForInt("Please, enter the NUMBER: ");
                    try
                    {
                        var r2 = MyMath.Fac(f);
                        Console.WriteLine($"RESULT: {r2}");
                    }
                    catch (StackOverflowException ex)
                    {
                        Console.WriteLine($"OVERFLOW: {ex.Message}");
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"OUT OF RANGE: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"CATCH: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("TASK 05 :: COMPLETED!");
        }
    }

    private static int AskForInt(string msg)
    {
        int result;
        string? input;

        do
        {
            Console.WriteLine(msg);
            input = Console.ReadLine();
        } while (!int.TryParse(input, out result));

        return result;
    }
}