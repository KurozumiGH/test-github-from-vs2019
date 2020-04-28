using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mylib.Core.Test
{
    [TestClass]
    public class TestCalc
    {
        [TestMethod]
        public void TestSum()
        {
            Assert.Equals(5, Calc.Sum(1, 4));
            Assert.Equals(5, Calc.Sum(3, 2));
            Assert.Equals(0, Calc.Sum(0, 0));
            Assert.Equals(0, Calc.Sum(-5, 5));
        }

        [TestMethod]
        public void TestError()
        {
            Assert.Equals(0, Calc.Sum(10, 20)); // NG
        }
    }
}
