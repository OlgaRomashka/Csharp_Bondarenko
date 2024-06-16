using System;


namespace L_09.Task_04
{
    public class MyStack
    {
        int[] mas;

        int count;

        public MyStack(int length = 4)
        {
            mas = new int[length];
        }

        public void Push(int x)
        {
            if (count >= mas.Length)
            {
               var mas1 = new int[mas.Length * 2];
               Array.Copy(mas, 0, mas1, 1, mas.Length);
               mas = mas1;
            }

            mas[count] = x;
            count++;
        }
        public int Pop()
        {
            count--;
            var i = mas[count];

           return  i;
        }
   
    }
}
