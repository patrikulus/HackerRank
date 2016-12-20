using BaseTestFixture;
using NUnit.Framework;

namespace _01_Warnup
{
    [TestFixture]
    public class _08_time_conversion_Test : BaseFixture
    {
        public override string StdIn => "07:05:45PM";
        public override string ExpectedStdOut => "19:05:45";
        protected override void RunLogic()
        {
            _08_time_conversion.Main();
        }
    }
}