using System;

namespace L_09.Task_02
{
    public class Task2
    {
        public static void Execute()
        {
            var s = "abcdf";
            MyString str1 = new MyString();

            var r = str1.Reverse(s);

            Console.WriteLine($"{s} ==> {r}");
        }
    }
}
