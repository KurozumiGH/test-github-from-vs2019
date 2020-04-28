using System;
using Xunit;

namespace MyLib.xTest
{
    public class CalcTest
    {
        [Fact]
        public void TestCalc()
        {
            Assert.Equal(3, Calc.Add(1, 2));
            Assert.Equal(3, Calc.Add(4, -1));
            Assert.Equal(0, Calc.Add(0, 0));
            Assert.Equal(0, Calc.Add(-1, 1));

            Assert.Equal(-3, Calc.Add(-1, -2));
        }
    }
}
