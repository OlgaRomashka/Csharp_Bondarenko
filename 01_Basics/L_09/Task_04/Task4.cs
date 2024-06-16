using L_09.Task_03;
using System;

namespace L_09.Task_04
{
    public class Task4
    {
        public static void Execute()
        {
            MyStack stak = new MyStack(4);
            stak.Push(1);
            stak.Push(2);
            stak.Push(3);
            stak.Push(4);
            stak.Push(5);
            stak.Push(6);

            var a = stak.Pop();
            var b = stak.Pop();

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
