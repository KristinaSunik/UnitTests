using System;

public class Words
{
	/// <summary>
    /// reverses all the words in a sentence
    /// </summary>
    /// <param name="sentence">the string to double</param>
    /// <returns>reversed sentence</returns>
	public static string Reverse(string sentence)
	{
		string [] words = sentence.Split(' ');
		string [] reversedSentence = new string [words.Length];
		int j = 0; //itterations in reversedSentense
		for (int i = words.Length - 1; i >= 0; i--)
		{
			reversedSentence[j] = words[i];
			j++;
		}

		return string.Join(" ",reversedSentence);
	}
}
