using System;

namespace L_09.Task_03
{
    public static class DateTimeExtension
    {
        public static string GetInfo(this DateTime dateTime) 
        {
            return $"День {dateTime:dd} месяца {dateTime:MMMM} года {dateTime.Year + 5501} от сотворения мира";
        }
    }
}
