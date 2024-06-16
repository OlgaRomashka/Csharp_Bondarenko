using System;

namespace L_09.Task_06
{
    public class IntReader : IReadable<int>
    {
        private int[] mas;
        public IntReader(int[] intReader)
        {
            mas = intReader;
        }
        public int Read(int index)
        {
            if (index < 0 || index >= mas.Length)
            {
                Console.Write("Index is out of range");

                return 0;
            }
            return mas[index];
        }

        public void Save(int index, int item)
        {
            if (index >= 0 && index < mas.Length)
            {
                mas[index] = item;
            }
            else
            {
                Console.Write("Index is out of range");
            }
        }
    }
}