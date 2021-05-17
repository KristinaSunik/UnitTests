using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ConsoleApp.Tests
{
    [TestFixture]
    public class PhoneNumbersTests
    {
        [TestCaseSource(nameof(DataForGetFromTheText))]
        public void GetFromTheText_ConvertText_ReturnsListOfNumbers(string text, List<string> expectedResult)
        {
            //Act
            var result = PhoneNumbers.GetFromTheText(text);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        private static readonly List<TestCaseData> DataForGetFromTheText =
            new List<TestCaseData>(new[]
            {
                new TestCaseData ("sjdfkh 89313675489, +78(6574)83-24-56", new List <string> {"89313675489", "786574832456"}),
                new TestCaseData($"hsdfn 678547{Environment.NewLine}67325", new List <string>  {}),
                new TestCaseData(" is +7 (921) 345-67-89 kekeke", new List <string> {"79213456789"}),
                new TestCaseData("sjhfj785646376219kjsdfkshhshefekh 893256476532", new List <string>  {"785646376219", "893256476532"}),
                new TestCaseData("", new List <string> {}),
                new TestCaseData("jdhgd hdjfgjsd home", new List <string> {})
            });
    }
}