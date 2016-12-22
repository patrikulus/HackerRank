using System.Collections.Generic;
using BaseTestFixture;
using NUnit.Framework;

namespace _01_Warnup
{
    [TestFixture]
    public class _09_circular_array_rotation_Test : BaseFixture
    {
        public string StdIn => "3 2 3\r\n" +
                                        "1 2 3\r\n" +
                                        "0\r\n" +
                                        "1\r\n" +
                                        "2";

        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData(StdIn, "2\r\n3\r\n1\r\n");
        }

        protected override void RunLogic()
        {
            _09_circular_array_rotation.Main();
        }
    }
}
