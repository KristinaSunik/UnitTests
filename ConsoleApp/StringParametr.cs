using System;

public class StringParametr
{
	/// <summary>
    /// doubles all characters in the string which are in the second string
    /// </summary>
    /// <param name="first">the string to double</param>
    /// <param name="second">has all the chars to double</param>
    /// <returns>doubled string</returns>
    public static string DoubleLetters(string first, string second)
	{
		for (int i = 0; i < second.Length - 1; i++)   // removes all doubled letters
	    {
		    for (int j = i + 1; j < second.Length; j++)
			{
				if(second[i] == second[j])
                {
					second = second.Remove(j, 1);
                }
			}
		}

		for (int i = 0; i < second.Length; i++)     //doubles the first string whith chars from second string
	    {
			if(second[i] == ' ')
            {
				continue;
            }

		    for (int j = 0; j < first.Length; j++)
			{
                if(second[i] == first[j])
                {
					first = first.Insert(j, second[i].ToString());
					j++;
                }
		    }
	    }

		if(string.IsNullOrWhiteSpace(first))
        { 
		  first = "The string is empty";
		}

		return first;
	}
}
