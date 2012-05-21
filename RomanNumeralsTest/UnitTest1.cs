using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsTest
{
    [TestClass]
    public class UnitTest1
    {
        private RomanNumerals1 convertor = new RomanNumerals1();


        [TestMethod]
        public void TestSingleSymbols()
        {
            Assert.AreEqual("I", convertor.ToRomanNumerals(1));
            Assert.AreEqual("V", convertor.ToRomanNumerals(5));
            Assert.AreEqual("X", convertor.ToRomanNumerals(10));
            Assert.AreEqual("L", convertor.ToRomanNumerals(50));
            Assert.AreEqual("C", convertor.ToRomanNumerals(100));
            Assert.AreEqual("D", convertor.ToRomanNumerals(500));
            Assert.AreEqual("M", convertor.ToRomanNumerals(1000));
        }
        
        [TestMethod]
        public void TestZero()
        {
            Assert.AreEqual("", convertor.ToRomanNumerals(0));
        }

        [TestMethod]
        public void TestOne()
        {
            Assert.AreEqual("I", convertor.ToRomanNumerals(1));
        }

        [TestMethod]
        public void TestTwo()
        {
            Assert.AreEqual("II", convertor.ToRomanNumerals(2));
        }

        [TestMethod]
        public void TestThree()
        {
            Assert.AreEqual("III", convertor.ToRomanNumerals(3));
        }

        [TestMethod]
        public void TestFour()
        {
            Assert.AreEqual("IV", convertor.ToRomanNumerals(4));
        }


        [TestMethod]
        public void TestEight()
        {
            Assert.AreEqual("VIII", convertor.ToRomanNumerals(8));
        }

        [TestMethod]
        public void TestNine()
        {
            Assert.AreEqual("IX", convertor.ToRomanNumerals(9));
        }

        [TestMethod]
        public void TestEleven()
        {
            Assert.AreEqual("XI", convertor.ToRomanNumerals(11));
        }

        [TestMethod]
        public void TestNinetyNine()
        {
            Assert.AreEqual("XCIX", convertor.ToRomanNumerals(99));
        }

        [TestMethod]
        public void TestHundredAndOne()
        {
            Assert.AreEqual("CI", convertor.ToRomanNumerals(101));
        }


        [TestMethod]
        public void TestTwoThousand()
        {
            Assert.AreEqual("MM", convertor.ToRomanNumerals(2000));
        }

        [TestMethod]
        public void Test2012()
        {
            Assert.AreEqual("MMXII", convertor.ToRomanNumerals(2012));
        }

        [TestMethod]
        public void Test2212()
        {
            Assert.AreEqual("MMCCXII", convertor.ToRomanNumerals(2212));
        }

        [TestMethod]
        public void Test1983()
        {
            Assert.AreEqual("MCMLXXXIII", convertor.ToRomanNumerals(1983));
        }
    }
}
