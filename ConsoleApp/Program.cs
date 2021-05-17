using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //A method which allows to define an average word length in an input string (returns double)
            string pathToText =  @"EnglishIT.txt";
            Files.CreateFileWithText(pathToText);
            string text = FileProvider.Get(pathToText);
            Console.WriteLine("An average word length is {0:0.000}", WordLength.CalculateAverage(text));
            Console.WriteLine();

            //A method that doubles in the first string parameter all characters belonging the second string parameter
            Console.WriteLine("Print a string, that you want to double:");
            string firstString = UserData.CheckInput();
            Console.WriteLine("Print another string with letters you want to double:");
            string secondString = UserData.CheckInput();
            string doubled = StringParametr.DoubleLetters(firstString, secondString);
            Console.WriteLine($"The string was doubled - {doubled}");
            Console.WriteLine();

            //A method, that returns the sum of two big numbers (bigger than long)
            string pathToNumbers = @"NumbersFromString.txt";
            Files.CreateFileWithNumbersFromString(pathToNumbers);
            string firstNumber = FileProvider.GetAstring(pathToNumbers, 0);
            string secondNumber = FileProvider.GetAstring(pathToNumbers, 1);
            Console.WriteLine("First number from file, that we want to sum is: {0}", firstNumber);
            Console.WriteLine("Second number from file, that we want to sum is: {0}", secondNumber);
            string summary = Sum.Calculate(firstNumber, secondNumber);
            Console.WriteLine($"The strings was summed : {summary}");
            Console.WriteLine();

            //A method which reverses all of the words within the string passed in
            string pathToSentence = @"EnglishIT.txt";
            string sentence = FileProvider.GetAstring(pathToSentence, 0);
            Console.WriteLine("The first string from file, that we want to reverse: {0}", sentence);
            string reversedSentence = Words.Reverse(sentence);
            Console.WriteLine($"The strings reversed : {reversedSentence}");
            Console.WriteLine();

            //A method that takes a string which contains text with phone numbers and saves the numbers to file
            string pathToTextWithNumbers = @"C:Text.txt";
            Files.CreateTextWithNumbers(pathToTextWithNumbers);
            text = FileProvider.Get(pathToTextWithNumbers);
            List <string> phoneNumbers = PhoneNumbers.GetFromTheText(text);
            Console.WriteLine(); 

            Console.WriteLine("A file Numbers.txt was created");
            Console.ReadKey();
        }
    }
}
