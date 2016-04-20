using System;
using System.Collections.Generic;
using System.Net.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labb1_UnitTesting;

namespace Labb1_UnitTesting_Test
{
    [TestClass]
    public class ResolverTests
    {
        private readonly Resolver resolver = new Resolver();

        [TestMethod]
        public void StringCount_CheckLengthOfInputString()
        {
            string input = "michael";

            int act = resolver.StringCount(input);
            int expected = 7;

            Assert.AreEqual(act, expected);
        }

        [TestMethod]
        public void StringType_StringIsWord()
        {
            string input = "michael";

            bool act = resolver.IsWord(input);
            bool expected = true;

            Assert.AreEqual(act, expected);
        }

        [TestMethod]
        public void StringType_StringIsNotWord()
        {
            string input = "michael d";

            bool act = resolver.IsWord(input);
            bool expected = false;

            Assert.AreEqual(act, expected);
        }

        [TestMethod]
        public void StringType_StringIsNumber()
        {
            string input = "1000";

            bool act = resolver.IsNumber(input);
            bool expected = true;

            Assert.AreEqual(act, expected);
        }

        [TestMethod]
        public void StringType_StringIsNotNumber()
        {
            string input = "michael";

            bool act = resolver.IsNumber(input);
            bool expected = false;

            Assert.AreEqual(act, expected);
        }

        [TestMethod]
        public void StringType_StringIsNone()
        {
            string input = "michael 93";

            bool act = resolver.IsNone(input);
            bool expected = true;

            Assert.AreEqual(act, expected);
        }

        [TestMethod]
        public void StringType_StringIsNotNone()
        {
            string input = "michael";

            bool act = resolver.IsNone(input);
            bool expected = true;

            Assert.AreEqual(act, expected);
        }

        [TestMethod]
        public void NextPalindrome_IsCorrectNextPalindrome()
        {
            int input = 220;

            int act = resolver.NextPalindrome(input);
            int expected = 222;

            Assert.AreEqual(act, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NextPalindrome_ShouldThrowException()
        {
            resolver.NextPalindrome(1000);
        }

        [TestMethod]
        public void NextPrime_IsValidNextPrimes()
        {
            int input = 100;

            List<int> act = resolver.NextPrime(input);
            List<int> expected = new List<int> {101, 103, 107};

            CollectionAssert.AreEqual(act, expected);
        }

        [TestMethod]
        public void NextPrime_IsInvalidNextPrimes()
        {
            int input = 100;

            List<int> act = resolver.NextPrime(input);
            List<int> expected = new List<int> { 101, 105, 107 };

            CollectionAssert.AreNotEqual(act, expected);
        }
    }
}