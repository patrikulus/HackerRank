using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/migratory-birds
    /// </summary>
    class MigratoryBirds
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] types_temp = Console.ReadLine().Split(' ');
            int[] types = Array.ConvertAll(types_temp, int.Parse);

            int[] birds = new int[5];
            for(var itr = 0; itr < n; itr++)
            {
                birds[types[itr] - 1]++;
            }

            int id = 1;
            int max = birds[0];
            for (var itr = 1; itr >= 0; itr--)
            {
                var value = birds[itr];
                if (value >= max)
                {
                    id = itr + 1;
                    max = value;
                }
            }

            Console.WriteLine(id);
        }

        [TestFixture]
        public class MigratoryBirdsTests : BaseFixture
        {
            protected override void RunLogic()
            {
                MigratoryBirds.Main();
            }

            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("6\r\n1 4 4 4 5 3\r\n", "4\r\n");
            }
        }
    }
}
