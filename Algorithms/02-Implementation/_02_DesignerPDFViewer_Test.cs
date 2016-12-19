using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    [TestFixture]
    public class _02_DesignerPDFViewer_Test : BaseFixture
    {
        public override string StdIn => "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5\r\nabc";
        public override string ExpectedStdOut => "9";

        protected override void RunLogic()
        {
            _02_DesignerPDFViewer.Main();
        }
    }
}
