using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(4, Calculator.Add(2,2));
        }

        [Test]
        public void FailingTest()
        {
            Assert.AreEqual(5, Calculator.Add(2,2));
        }
        
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }
    }

    public class Calculator
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
    }
}