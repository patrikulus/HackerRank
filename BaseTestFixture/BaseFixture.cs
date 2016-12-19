using System;
using System.IO;
using NUnit.Framework;

namespace BaseTestFixture
{
    [TestFixture]
    public abstract class BaseFixture
    {
        public abstract string StdIn { get; }
        public abstract string ExpectedStdOut { get; }

        [Test]
        public void Run()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            var reader = new StringReader(StdIn);
            Console.SetIn(reader);

            RunLogic();

            Assert.That(writer.ToString(), Is.EqualTo(ExpectedStdOut));
        }

        protected abstract void RunLogic();
    }
}
