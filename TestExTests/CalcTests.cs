using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestEx.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestCase(4, 2, 2.0f)]
        [TestCase(-4, 2, -2.0f)]
        [TestCase(4, -2, -2.0f)]
        [TestCase(0, 3, 0.0f)]
        [TestCase(5, 2, 2.5f)]
        [TestCase(1, 3, 0.333333343f)]
        public void DivideTest(int dividend, int divisor, float expectedQuotient)
        {
            var calc = new Calc();
            var quotient = calc.Divide(dividend, divisor);
            NUnit.Framework.Assert.AreEqual(expectedQuotient, quotient);
        }

        [TestCase(4, 2, 2, 4.0f)]
        [TestCase(-4, 2, 2, 0.0f)]
        [TestCase(4, -2, 2, 0.0f)]
        [TestCase(1, 3, 2, 2.333333343f)]
        public void DivideAndAddNumberTest(int dividend, int divisor, int addNumber, float expectedQuotient)
        {
            var calc = new Calc();
            var quotient = calc.DivideAndAddNumber(dividend, divisor, addNumber);
            NUnit.Framework.Assert.AreEqual(expectedQuotient, quotient);
        }

        [TestCase(0, 5, 5)]
        [TestCase(10, 5, 10)]
        [TestCase(4, 9, 9)]
        [TestCase(1, 1, 1)]
        public void BiggerNumberTest(int firstN, int secodN, int ExpectedBiggerNumber)
        {
            var calc = new Calc();
            var biggerNumber = calc.BiggerNumber(firstN, secodN);
            NUnit.Framework.Assert.AreEqual(ExpectedBiggerNumber, biggerNumber);
        }

        [Test]
        public void AlwaysZeroTest([Values(4, 7, -9, 1)] int numberToSub)
        {
            var calc = new Calc();
            var zeroNum = calc.AlwaysZero(numberToSub);
            NUnit.Framework.Assert.AreEqual(0, zeroNum);
        }
        
        [Test]
        public void FloatToIntConvertTest([Range(from: 0.1f, to: 1.0f, step: 0.1f)] float futureInt)
        {
            var calc = new Calc();
            int zeroNum = calc.FloatToIntConvert(futureInt);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsInstanceOfType(zeroNum, typeof(int));
        }

        /// <summary>
        /// Testy dodatkowe
        /// </summary>
/*
        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DivisionByZero_ThrowsException()
        {
            var calc = new Calc();
            calc.Divide(2, 0);
        }
*/

    }
}