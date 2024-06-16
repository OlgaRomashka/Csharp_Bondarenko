using System;

namespace L_09.Task_02
{
    public class MyString
    {
        public MyString()
        {
        }
        public MyString(string str)
        {
        }
        public MyString(string str1, string str2)
        {
        }

        public string Reverse(string str)
        {
            string s = string.Empty;

            for (var i = str.Length - 1; i >= 0; i--)
            {
                s += str[i];
            }
            return s;
        }
    }
}
