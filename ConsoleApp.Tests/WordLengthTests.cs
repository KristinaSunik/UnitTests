using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ConsoleApp.Tests
{
    [TestFixture]
    internal class WordLengthTests
    {
        [TestCaseSource(nameof(DataForCalculateAverage))]
        public void CalculateAverage_WordLength_ReturnsDoubleAverageWordLength(string text, double expectedResult)
        {
            //Act
            var result = WordLength.CalculateAverage(text);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        private static readonly List<TestCaseData> DataForCalculateAverage =
            new List<TestCaseData>(new[]
            {
                new TestCaseData ("hello epam pam pa ra ram", 3.1667),
                new TestCaseData("my name is Karl", 3),
                new TestCaseData("  who iis yours", 3.6667),
                new TestCaseData("abara", 5),
                new TestCaseData("epampampam rock", 7),
                new TestCaseData("", 0)
            });
    }
}