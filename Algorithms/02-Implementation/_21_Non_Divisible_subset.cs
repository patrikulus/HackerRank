using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/non-divisible-subset
    /// </summary>
    class _21_Non_Divisible_subset
    {
        public static void Main()
        {
            string[] temp = Console.ReadLine().Split(' ');
            int k = Convert.ToInt32(temp[1]);

            temp = Console.ReadLine().Split(' ');
            int[] values = Array.ConvertAll(temp, Convert.ToInt32);

            var divs = new Dictionary<int, int>();
            for (int i = 0; i < values.Length; i++)
            {
                int value = values[i];
                int missing = value % k;
                if (!divs.ContainsKey(missing))
                {
                    divs.Add(missing, 1);
                }
                else
                {
                    divs[missing] += 1;
                }
            }

            int count = 0;
            int j = 0;
            for (; j < values.Length; j++)
            {
                int left;
                if(!divs.TryGetValue(j, out left)) left = 0;

                int right;
                if (!divs.TryGetValue(k - j, out right)) right = 0;
                count += Math.Max(left, right);
            }

            if (2 * j == k)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
