using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class FileProvider
{   
    /// <summary>
    /// reads all the text from the file
    /// </summary>
    /// <param name="path">adress of the file</param>
    /// <returns>string from the file</returns>
    public static string Get(string path)
    {
        var reader = new StreamReader(path);
        var value = reader.ReadToEnd();
        reader.Close();
        return value;
    }

    /// <summary>
    /// writes the text to the file
    /// </summary>
    /// <param name="path">adress of the file</param>
    /// <param name="phoneNumbers">the List to save</param>
    public static void WriteToFile(string path, List <string> phoneNumbers)
    {
        File.WriteAllLines(path, phoneNumbers);
    }

    /// <summary>
    /// writes the text to the file
    /// </summary>
    /// <param name="path">adress of the file</param>
    /// <param name="text">the text to save</param>
    public static void WriteToFile(string path, string [] text)
    {
        File.WriteAllLines(path, text);
    }

    /// <summary>
    /// gets a string from the file
    /// </summary>
    /// <param name="path">adress of the file</param>
    /// <param name="numberOfString">string we need to read</param>
    /// <returns>a string we needed</returns>
    public static string GetAstring(string path, int numberOfString)
    {
        string theString = File.ReadLines(path).ElementAt(numberOfString);

        return theString;
    }
}
