using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ConsoleApp.Tests
{
    [TestFixture]
    internal class WordsTests
    {
        [TestCaseSource(nameof(DataForReverse))]
        public void Reverse_MakeWordsInReversedPosition_ReturnsReversedText(string text, string expectedResult)
        {
            //Act
            var result = Words.Reverse(text);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        private static readonly List<TestCaseData> DataForReverse =
            new List<TestCaseData>(new[]
            {
                new TestCaseData ("Hello Epam", "Epam Hello"),
                new TestCaseData("My name is Karl", "Karl is name My"),
                new TestCaseData("Who is yours", "yours is Who"),
                new TestCaseData("abracadabra", "abracadabra"),
                new TestCaseData("epam - pam - pam - pa - ram", "ram - pa - pam - pam - epam"),
                new TestCaseData("The string is empty", "empty is string The")
            });
    }
}