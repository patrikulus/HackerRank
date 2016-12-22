using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace BaseTestFixture
{
    [TestFixture]
    public abstract class BaseFixture
    {
        [Test]
        public void Run()
        {
            foreach (TestData data in Cases())
            {
                var writer = new StringWriter();
                Console.SetOut(writer);
                var reader = new StringReader(data.StdIn);
                Console.SetIn(reader);

                RunLogic();

                string output = writer.ToString();
                Assert.That(output, Is.EqualTo(data.StdOut));
            }
        }

        protected abstract void RunLogic();
        protected abstract IEnumerable<TestData> Cases();
    }
}
