using System;

namespace L_09.Task_06
{
    public class StringReader : IReadable<string>
    {
        private string[] mas;
        public StringReader(string[] stringReader) 
        {
            mas = stringReader;  
        }

        public string Read(int index)
        {
            if (index < 0 || index >= mas.Length)
            {
                Console.Write("Index is out of range");

                return null;
            }
            return mas[index];
        }

        public void Save(int index, string item)
        {
            if(index >= 0 && index < mas.Length)
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
