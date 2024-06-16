using L_09.Task_05;
using System;


namespace L_09.Task_06
{
    public class Task6
    {
        public static void Execute()
        {
            string[] s1 = ["One", "Two", "Three"];
            int[] s2 = [1, 2, 3, 4];

            IReadable<string> r1 = new StringReader(s1);
            IReadable<int> r2 = new IntReader(s2);

            var result = r1.Read(1);
            Console.WriteLine(result);

            r1.Save(1, "six");
            var result1 = r1.Read(1);
            Console.WriteLine(result1);

            Console.WriteLine(r2.Read(3));
            
        }
    }
}