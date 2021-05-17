using System;

public class WordLength
{
	/// <summary>
    /// calculate average word length in the string
    /// </summary>
    /// <param name="line">a string from the file</param>
    /// <returns>average length of the words</returns>
	public static double CalculateAverage(string text)
	{
		double average;
		text = text.Trim();
		text = text.Replace("\n", " ");
		text = text.Replace("\r", " ");

		for (int i = 0; i < text.Length; i++)        // replace all punctuation to space
        {
			if(Char.IsPunctuation(text[i]) || Char.IsSeparator(text[i]) || Char.IsSymbol(text[i]))
            {
				text = text.Replace(text[i],' ');
            }
        }

		text = text.Trim();
		text = text.Replace("   ", " ");
		text = text.Replace("  "," ");
		string[] words = text.Split(' ');
		int wordsLength = words.Length;             //counts words in the string
		int countLetters = 0;
		text = string.Concat(words);
        for (int i = 0; i < text.Length; i++)       //counts total letters
        {
            if(Char.IsLetter(text[i]))
            {
				countLetters++;
            }
        }

		average = Math.Round((double)countLetters/wordsLength, 4);
		

		return average;
	}
}
