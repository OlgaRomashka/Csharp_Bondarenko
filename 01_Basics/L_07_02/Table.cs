using System;
using System.Runtime.Intrinsics.Arm;

namespace L_07_02
{
    public class Table
    {
        public Table(int number, params Menu[] menu)
        {
            Number = number;
            Orders = menu.ToList();
        }
        public int Number { get; }

        public List<Menu> Orders { get; }
    }   
}
