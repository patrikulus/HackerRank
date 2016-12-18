using BaseTestFixture;
using NUnit.Framework;

namespace _08_time_conversion
{
    [TestFixture]
    public class Tests : BaseFixture
    {
        public override string StdIn => "07:05:45PM";
        public override string ExpectedStdOut => "19:05:45";
        protected override void RunLogic()
        {
            Solution.Main(null);
        }
    }
}
