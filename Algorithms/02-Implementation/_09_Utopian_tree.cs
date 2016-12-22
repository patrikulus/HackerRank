using System;
using System.Collections.Generic;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/utopian-tree
    /// </summary>
    class _09_Utopian_tree
    {
        public static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            var tree = new UtopianTree();
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int height = tree.ProcessCycles(n);
                Console.WriteLine(height);
            }
        }

        class UtopianTree
        {
            private enum Cycle
            {
                Spring,
                Summer
            }

            public int ProcessCycles(int cycles)
            {
                Cycle current = Cycle.Spring;
                int height = 1;

                for (int i = 0; i < cycles; i++)
                {
                    if (current == Cycle.Spring)
                    {
                        height *= 2;
                        current = Cycle.Summer;
                    }
                    else
                    {
                        height += 1;
                        current = Cycle.Spring;
                    }
                }

                return height;
            }
        }
    }
}
