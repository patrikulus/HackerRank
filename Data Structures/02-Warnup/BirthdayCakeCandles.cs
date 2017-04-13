using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Warnup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/birthday-cake-candles
    /// </summary>
    public class BirthdayCakeCandles
    {
        public static void Main()
        {
            Console.ReadLine(); // skip first line

            IEnumerable<int> height = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x));

            int max = 0;
            int count = 0;
            foreach (int h in height)
            {
                if (h > max)
                {
                    max = h;
                    count = 1;
                }
                else if (h == max)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}