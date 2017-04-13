using System;

namespace _02_Warnup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/the-birthday-bar
    /// </summary>
    public class TheBirthdayBar
    {
        static int getWays(int[] squares, int expectedSum, int numberOfParam)
        {
            if (squares.Length < numberOfParam)
            {
                return 0;
            }

            int sum = 0;
            int result = 0;

            for (int i = 0; i < numberOfParam; i++)
            {
                sum += squares[i];
            }
            if (sum == expectedSum)
                result++;

            int firstElement = squares[0];
            for (int i = numberOfParam; i < squares.Length; i++)
            {
                sum -= firstElement;
                firstElement = squares[i - numberOfParam + 1];
                sum += squares[i];
                if (sum == expectedSum)
                    result++;
            }
            return result;
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = getWays(s, d, m);
            Console.WriteLine(result);
        }
    }
}