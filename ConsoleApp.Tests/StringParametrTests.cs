using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ConsoleApp.Tests
{
    [TestFixture]
    internal class StringParametrTests
    {
        [TestCaseSource(nameof(DataForDoubleLetters))]
        public void DoubleLetters_DoubleLettersInText_ReturnsStringWithDoubledLetters(string text, string letters, string expectedResult)
        {
            //Act
            var result = StringParametr.DoubleLetters(text, letters);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        private static readonly List<TestCaseData> DataForDoubleLetters =
            new List<TestCaseData>(new[]
            {
                new TestCaseData ("hello epam", "E", "hello epam"),
                new TestCaseData("my name is Karl", "ml", "mmy namme is Karll"),
                new TestCaseData("  who iis yours", "  wwhhi", "  wwhho iiiis yours"),
                new TestCaseData("aba", "b", "abba"),
                new TestCaseData("epampampam", "", "epampampam"),
                new TestCaseData("", "hbbj", "The string is empty")
            });
    }
}