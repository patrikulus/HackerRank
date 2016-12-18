using System;

class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i != n + 1; i++)
        {
            int spaces = n - i;
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(' ');
            }

            int specialChars = n - spaces;
            for (int j = 0; j < specialChars; j++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }
    }
}
