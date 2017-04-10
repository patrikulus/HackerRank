using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Warnup
{
    public class BirthdayCakeCandles
    {
        public static void Main()
        {
            Console.ReadLine(); // skip first line

            IEnumerable<int> height = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x));

            int max = 0;
            var dic = new Dictionary<int, int>();
            foreach (int h in height)
            {
                int value;
                if (!dic.TryGetValue(h, out value))
                {
                    dic[h] = 1;
                }
                else
                {
                    value++;
                    dic[h] = value;
                    max = Math.Max(max, value);
                }
            }

            Console.WriteLine(max);
        }
    }
}