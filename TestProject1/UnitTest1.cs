using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = new Fraction();
            var sum = x.Add(0);
            Assert.Equal(0,sum);
        }

        public class Fraction
        {
            public int Add(int input)
            {
                return 0;
            }
        }
    }
}
