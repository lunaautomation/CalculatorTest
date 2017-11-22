using System;
using Caculator;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CanReciveOneNumber()
        {
            var Calculate = new Calculator();
            string testdata = "11";
            int expected = 11;
            int result = Calculate.Calc(testdata);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CanAddTwoValidNumbers()
        {
            var Calculate = new Calculator();
            string testdata = "11,11";
            int expected = 22;
            int result = Calculate.Calc(testdata);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CanAddThreeValidNumbers()
        {
            var Calculate = new Calculator();
            string testdata = "11,11,11";
            int expected = 33;
            int result = Calculate.Calc(testdata);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CanHandleNullReturnsZero()
        {
            var Calculate = new Calculator();
            int expected=0;
            int result = Calculate.Calc(null);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void CanHandleSpecialCharacters()
        {
            var Calculate = new Calculator();
            string testdata = "4,*,$";
            int expected = 0;
            int result = Calculate.Calc(testdata);
            Assert.AreEqual(expected, result);
        }
    }
}
