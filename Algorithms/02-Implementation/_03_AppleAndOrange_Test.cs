using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    [TestFixture]
    public class _03_AppleAndOrange_Test : BaseFixture
    {
        public override string StdIn => "7 11\r\n"
                                        + "5 15\r\n"
                                        + "3 2\r\n"
                                        + "-2 2 1\r\n"
                                        + "5 -6\r\n";

        public override string ExpectedStdOut => "1\r\n1\r\n";

        protected override void RunLogic()
        {
            _03_AppleAndOrange.Main();
        }
    }
}
