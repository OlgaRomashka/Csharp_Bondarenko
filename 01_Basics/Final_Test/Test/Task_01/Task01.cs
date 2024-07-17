namespace Test.Task_01;

public class Task01
{
    private static Random _random = new();

    public static void Execute()
    {
        var arr = GetTwoDimensionalArray(10, 10);

        PrintArray(arr);

        Console.WriteLine("---------------------------");

        Modify(arr);

        PrintArray(arr);
    }

    private static void Modify(int[,] arr)
    {
        var n = (float)arr.GetLength(0) / arr.GetLength(1);
        
        Console.WriteLine($"N: {n}");
        
        for (var y = 0; y < arr.GetLength(1); y++)
        {
            for (var x = 0; x < arr.GetLength(0); x++)
            {
                if (x > Math.Round(y * n))
                {
                    arr[x, y] = 1;
                }
            }
        }
    }

    private static void PrintArray(int[,] arr)
    {
        for (var y = 0; y < arr.GetLength(1); y++)
        {
            var line = new int[arr.GetLength(0)];

            for (var x = 0; x < line.Length; x++)
            {
                line[x] = arr[x, y];
            }

            Console.WriteLine($"[ {string.Join(", ", line)} ]");
        }
    }

    private static int[,] GetTwoDimensionalArray(int xSize, int ySize)
    {
        var arr = new int[xSize, ySize];

        for (var y = 0; y < ySize; y++)
        {
            for (var x = 0; x < xSize; x++)
            {
                arr[x, y] = _random.Next(2, 10);
            }
        }

        return arr;
    }
}