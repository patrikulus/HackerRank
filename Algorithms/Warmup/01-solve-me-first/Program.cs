﻿using System;

namespace _01_solve_me_first
{
    public class Solution
    {
        private static int solveMeFirst(int a, int b)
        {
            return a + b;
        }

        public static void Main(String[] args)
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
    }
}
