using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _01_Warnup
{
    [TestFixture]
    public class _08_time_conversion_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("07:05:45PM", "19:05:45");
        }

        protected override void RunLogic()
        {
            _08_time_conversion.Main();
        }
    }
}