using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ConsoleApp.Tests
{
    [TestFixture]
    internal class SumTests
    {

        [TestCaseSource(nameof(DataForCalculate))]
        public void Calculate_SumOfTwoBiggerThanLongNumbers_ReturnsStringWithSum(string firstNumber, string secondNumber, string expectedResult)
        {
            //Act
            var result = Sum.Calculate(firstNumber, secondNumber);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        private static readonly List<TestCaseData> DataForCalculate =
            new List<TestCaseData>(new[]
            {
                new TestCaseData ("9999999999999999", "2", "10000000000000001"),
                new TestCaseData("9", "8", "17"),
                new TestCaseData("999999999999999", "1111", "1000000000001110"),
                new TestCaseData("1 234 567", "9 876 543", "11111110"),
                new TestCaseData("0", "0", "0"),
                new TestCaseData("15 780 000", "220 000", "16000000"),
                new TestCaseData("220 000", "15 780 000", "16000000")
            });
    }
}