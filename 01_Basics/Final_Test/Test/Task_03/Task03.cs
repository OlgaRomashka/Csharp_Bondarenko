namespace Test.Task_03;

public class Task03
{
    public static void Execute()
    {
        int[] arr = [1, 2, 5, -2, -9, 25, 0, 1, -99];
        
        var sorted = GetSorted(arr);

        Console.WriteLine(string.Join(", ", sorted));
    }

    private static IEnumerable<int> GetSorted(IEnumerable<int> arr)
    {
        var enumerable = arr.ToArray();
        
        return enumerable.OrderBy(x => x)
            .Skip((int)Math.Round(enumerable.Length * 0.5))
            .OrderDescending()
            .Select(x => x * x);
    }
}