using BaseTestFixture;
using NUnit.Framework;

namespace _02_Implementation
{
    [TestFixture]
    public class _02_DesignerPDFViewer_Test : BaseFixture
    {
        public override string StdIn => "1 2 3 4 5\r\n";
        public override string ExpectedStdOut => "10 14\r\n";

        protected override void RunLogic()
        {
            _02_DesignerPDFViewer.Main();
        }
    }
}
