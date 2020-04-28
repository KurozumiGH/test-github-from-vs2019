using System;
using Xunit;

namespace MyLib.xTest
{
    public class CalcTest
    {
        [Fact]
        public void TestCalc()
        {
            Calc.Add(1, 2);
        }
    }
}
