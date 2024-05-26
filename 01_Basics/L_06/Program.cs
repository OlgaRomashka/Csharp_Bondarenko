namespace L_06
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = Helper.GetRandom(1, 10);

            var mas = new int[x];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Helper.GetRandom(0, 100);
            }

            var l = string.Join(",", mas);

            Console.WriteLine(l);

            //T[] FindAll<T> (T[] array, Predicate<T> match) 

            var evenNumbers = Array.FindAll(mas, x => x % 2 == 0);

            var evens = string.Join(", ", evenNumbers);

            Console.WriteLine(evens);
        }
    }
}
