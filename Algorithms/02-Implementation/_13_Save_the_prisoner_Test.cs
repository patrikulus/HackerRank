using System.Collections.Generic;
using BaseTestFixture;

namespace _02_Implementation
{
    public class _13_Save_the_prisoner_Test : BaseFixture
    {
        protected override IEnumerable<TestData> Cases()
        {
            yield return new TestData("1\r\n5 2 1\r\n", "2");
        }

        protected override void RunLogic()
        {
            _13_Save_the_prisoner.Main();
        }
    }
}
