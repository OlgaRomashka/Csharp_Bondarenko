namespace Test.Task_03;

public class Task03
{
    public static void Execute()
    {
        int[] arr = [1, 2, 5, -2, -9, 25, 0, 1, -99];
        
        var sorted = arr
            .OrderBy(x => x)
            .Skip((int)Math.Round(arr.Length * 0.5))
            .OrderDescending()
            .Select(x => x * x);

        Console.WriteLine(string.Join(", ", sorted));
    }
}