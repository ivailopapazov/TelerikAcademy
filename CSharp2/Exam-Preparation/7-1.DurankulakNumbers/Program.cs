using System;
using System.Collections.Generic;

// http://bgcoder.com/Contests/Submissions/View/282528

class Program
{
    static void Main()
    {
        // Make dictionary with Durank dgits
        Dictionary<string, int> durankDigits = new Dictionary<string, int>();

        // COunter
        int count = 0;

        // filling dictionary with digits
        for (char i = 'A'; i <= 'Z'; i++, count++)
        {
            durankDigits.Add(i.ToString(), count);
        }

        for (char i = 'a'; i <= 'f'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                durankDigits.Add(i.ToString() + j, count);
                count++;
            }
        }

        // Input
        string number = Console.ReadLine();
        string currentDigit = "";
        long result = 0;
        int position = 0;

        // count digits
        foreach (var digit in number)
	    {
            if (char.IsUpper(digit))
            {
                position++;
            }
	    }

        for (int i = 0; i < number.Length; i++)
        {
            currentDigit += number[i].ToString();

            if (char.IsUpper(number[i]))
            {
                position--;
                result += durankDigits[currentDigit] * (long)Math.Pow(168, position);
                currentDigit = "";
            }
        }

        Console.WriteLine(result);
    }
}
