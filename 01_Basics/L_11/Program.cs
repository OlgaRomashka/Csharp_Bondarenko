using System.Runtime.CompilerServices;

namespace L_11
{
    internal class Program
    {
        public delegate void MyDelegate(bool state);
        static void Main()
        {
            var checkbox = new Checkbox();

            checkbox.DoClick();
            checkbox.DoClick();
            checkbox.DoClick();
            checkbox.DoClick();
            checkbox.DoClick();

            checkbox.Click += () =>
            {
                var state = checkbox.State ? "on" : "off";

                Console.WriteLine($"Checkbox {state}");
            };
        }
    }
}
