using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_09.Task_01
{
    internal class Task1
    {
        public static void Execute()
        {
            int[,,] mas = new int[4,2,2] {{{ 1, 2 },{ 3, 4 } },
                                       {{ 4, 5 } ,{ 6, 7 } },
                                       {{ 7, 8 },{ 9, 10 } },
                                       {{ 10, 11 },{ 12, 13 }}};

            Console.Write("{");

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{");
                    for (int n = 0; n < mas.GetLength(2); n++)
                    {
                        Console.Write(mas[i, j, n]);

                        if (n != mas.GetLength(2) - 1)
                        {
                            Console.Write(",");
                        }
                    }
                    Console.Write("}");
                    if (j != mas.GetLength(1) - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("}");

                if (i != mas.GetLength(0) - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("}");
        }
    }
}
