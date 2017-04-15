using System;
using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/drawing-book
    /// </summary>
    class DrawingBook
    {
        private static int Solve(int n, int page)
        {
            int fromStart = FromLeft(n, page);
            int fromEnd = FromRight(n, page);

            int result = Math.Min(fromStart, fromEnd);

            return result;
        }

        private static int FromLeft(int pages, int page)
        {
            int result = 0;

            int currentPage = 1;
            while (currentPage != page && currentPage <= page)
            {
                currentPage += 2;
                result++;
            }

            return result;
        }

        private static int FromRight(int pages, int page)
        {
            int result = 0;
            int currentPage = pages;

            while (currentPage != page && currentPage >= page)
            {
                if (!IsEven(currentPage) && currentPage - 1 == page)
                {
                    break;
                }

                currentPage -= 2;
                result++;
            }

            return result;
        }

        private static bool IsEven(int number) => number % 2 == 0;

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int result = Solve(n, p);
            Console.WriteLine(result);
        }

        [TestFixture]
        public class DrawingBookTests : BaseFixture
        {
            protected override void RunLogic()
            {
                DrawingBook.Main();
            }

            protected override IEnumerable<TestData> Cases()
            {
                yield return new TestData("6\r\n2\r\n", "1\r\n");
                yield return new TestData("6\r\n3\r\n", "1\r\n");
                yield return new TestData("100\r\n4\r\n", "2\r\n");
                yield return new TestData("100\r\n5\r\n", "2\r\n");
                yield return new TestData("5\r\n5\r\n", "0\r\n");
                yield return new TestData("5\r\n4\r\n", "0\r\n");
                yield return new TestData("99\r\n99\r\n", "0\r\n");
                yield return new TestData("99\r\n98\r\n", "0\r\n");
                yield return new TestData("99\r\n97\r\n", "1\r\n");
                yield return new TestData("99\r\n96\r\n", "1\r\n");
            }
        }
    }
}
