using System;

namespace _01_Warnup
{
    class _08_time_conversion
    {
        public static void Main()
        {
            string time = Console.ReadLine();
            DateTime date = DateTime.Parse(time);
            Console.Write(date.ToString("HH:mm:ss"));
        }
    }
}
