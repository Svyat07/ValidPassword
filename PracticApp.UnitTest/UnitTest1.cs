using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodsLib;
using System;

namespace PracticApp.UnitTest
{
    [TestClass]
    public class PasswordTest
    {
        void ValidPasswordOnDigit(string passwordSym, bool expectedResult)
        {
            var result = MethodsFromLib.ContainDigit(passwordSym);
            Assert.AreEqual(expectedResult, result);
        }
        void ValidPasswordOnUpperLetter(string passwordSym, bool expectedResult)
        {
            var result = MethodsFromLib.ContainsUpperLetter(passwordSym);
            Assert.AreEqual(expectedResult, result);
        }
        void ValidPasswordLenghtMax(string passwordSym, bool expectedResult)
        {
            var result = MethodsFromLib.ContainMax(passwordSym);
            Assert.AreEqual(expectedResult, result);
        }
        void ValidPasswordLenghtMin(string passwordSym, bool expectedResult)
        {
            var result = MethodsFromLib.ContainMin(passwordSym);
            Assert.AreEqual(expectedResult, result);
        }
        void ValidPasswordSpec(string passwordSym, bool expectedResult)
        {
            var result = MethodsFromLib.ContainSpec(passwordSym);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CheckDigitPass()
        {
            ValidPasswordOnDigit("1a", true);
        }
        [TestMethod]
        public void CheckDigitFail()
        {
            ValidPasswordOnDigit("aA", false);
        }
        [TestMethod]
        public void CheckUpperLetterPass()
        {
            ValidPasswordOnUpperLetter("A", true);
        }
        [TestMethod]
        public void CheckUpperLetterFail()
        {
            ValidPasswordOnUpperLetter("a", false);
        }
        [TestMethod]
        public void CheckMaxLenghtFail()
        {
            ValidPasswordLenghtMax("aaaaaaaaaaaaaaaaaaaaaaa", false);
        }
        [TestMethod]
        public void CheckMaxLenghtTrue()
        {
            ValidPasswordLenghtMax("aaaaaaaaaaaaaaaaaa", true);
        }
        [TestMethod]
        public void CheckMinLenghtTrue()
        {
            ValidPasswordLenghtMin("aaaaaaaa", true);
        }
        [TestMethod]
        public void CheckMinLenghtFail()
        {
            ValidPasswordLenghtMin("aaaaaa", false);
        }
        [TestMethod]
        public void LetterSpecFail()
        {
            ValidPasswordSpec("aaaaaaaa", false);
        }

    }
}
