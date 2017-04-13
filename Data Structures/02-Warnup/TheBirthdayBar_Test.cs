using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Warnup
{
    [TestFixture]
    public class TheBirthdayBar_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("6\r\n1 1 1 1 1 1\r\n3 2\r\n", "0\r\n");
            yield return new TestData("5\r\n1 2 1 3 2\r\n3 2\r\n", "2\r\n");
            yield return new TestData("1\r\n4\r\n4 1\r\n", "1\r\n");
        }

        protected override void RunLogic()
        {
            TheBirthdayBar.Main();
        }
    }
}
