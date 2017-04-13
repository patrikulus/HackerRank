using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _02_Warnup
{
    [TestFixture]
    public class BirthdayCakeCandles_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("4\r\n3 2 1 3\r\n", "2\r\n");
        }

        protected override void RunLogic()
        {
            BirthdayCakeCandles.Main();
        }
    }
}
