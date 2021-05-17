using System;

public class Files
{
    public static void CreateFileWithText(string pathToText)
    {
        string [] text = { "abbreviation = shortened form of a word or expression that uses the first few letters" +
            " or the main letters of the word to represent it «The abbreviation ’RAM’ stands for Random Access " +
            "Memory». ",
            "analysis = critical study or examination of something  financial analysis was carried out " +
            "in order to improve cost efficiency.",
            "appliance = a device or tool that performs a specific task «They sell a wide range of " +
            "virtual appliances».",
            "application = a program designed to do a specific job «This database application lets you " +
            "manage your contacts and organise your projects».",
            "arise = happen/begin to exist(formal) «Problems may arise when trying to request data " +
            "from a remote web service».", "demand = customers’ need for a product " +
            "«Online keyword selector tools may help you find out whether certain products are in high demand».", 
            "detailed = giving a lot of information «A more detailed description is available on our website»." ,
            "develop = make something bigger/more complex/ more advanced " +
            "«We have decided to develop a new database app».", "develop = make something bigger/more complex/" +
            " more advanced «We have decided to develop a new database app».", "drawback = disadvantage, " +
            "a feature that’s not good«The main drawback of this product is the high cost»." };
        
        FileProvider.WriteToFile(pathToText, text);
    }

    public static void CreateFileWithNumbersFromString(string pathToNumbers)
    {
        string[] numbers = { "15 780 000", "220 000" };
        FileProvider.WriteToFile(pathToNumbers, numbers);
    }

    public static void CreateTextWithNumbers(string pathToTextWithNumbers)
    {
        string[] lines = { "Bla bla bla my number is +7 (921) 345-67-89 kekeke", 
            "Blo Blo blo +375 (34) 444-7843 ololo", "hskjfdkjfkshfjs sjdhfjsdhf 56",
            "dfjhjd 76 89", "+9 (567) 987-76-87 or sddfnks", "sdfksnfs d sdjfnsdjf v 3 343 321-34-34",
            "sdjfssdf sdfsf or +456 (56) 453-6589" };
        FileProvider.WriteToFile(pathToTextWithNumbers, lines);
    }
}
