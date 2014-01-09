using System;

class ReverseNumberDigits
{
    static string ReverseCharacters(string word)
    {
        // Taking input string as character array
        char[] wordArray = word.ToCharArray();

        // Reverse the array
        Array.Reverse(wordArray);

        // Return reversed array as string
        return new string(wordArray);
    }
    static void Main()
    {
        // User Input
        Console.Write("Please enter a number: ");
        string word = Console.ReadLine();

        // Parsing the inverted string to integer
        int invertedNumber = int.Parse(ReverseCharacters(word));

        // Print Result
        Console.WriteLine(invertedNumber);
    }
}
