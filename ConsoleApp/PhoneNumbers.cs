using System;
using System.Collections.Generic;

public class PhoneNumbers
{
	//(+X (XXX) XXX-XX-XX or X XXX XXX-XX-XX or +XXX (XX) XXX-XXXX)
	/// <summary>
    /// finds all the numbers in the text and save them to new file on C:\\ disk
    /// </summary>
    /// <param name="text">the text that have phone numbers inside</param>
    /// <returns>List of phone numbers</returns>
	public static List<string> GetFromTheText(string text)
	{
		string pathToSave = @"Numbers.txt";
		string currentNumber = string.Empty;
		List <string> phoneNumbers = new List<string> ();
		text = text.Replace("-", "");
		text = text.Replace("+", "");
		text = text.Replace("(", "");
		text = text.Replace(")", "");
		text = text.Replace(" ", "");

		for (int i = 0; i < text.Length; i++)
		{
			if(Char.IsDigit(text[i]))
            {
				if(i + 11 < text.Length)
                { 
				    currentNumber = text.Substring(i, 11);
					for (int j = 0; j < currentNumber.Length; j++)
					{
						if(char.IsDigit(currentNumber[j]))
					    {
							continue;
						}
                        else
                        {
							currentNumber = string.Empty;
							break;
                        }
					}

					if(char.IsDigit(text[i + 11]))
                    {
                        currentNumber += text[i + 11];
                    }
				}
            }

			if (!string.IsNullOrEmpty(currentNumber) && currentNumber.Length >= 11)
            {
				phoneNumbers.Add(currentNumber);
				currentNumber = string.Empty;
				i = i + 11;
            }

		}

		FileProvider.WriteToFile(pathToSave, phoneNumbers);
		return phoneNumbers;
	}
}
