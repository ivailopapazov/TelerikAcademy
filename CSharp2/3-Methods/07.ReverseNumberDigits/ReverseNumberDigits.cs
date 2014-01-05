using System;

class ReverseNumberDigits
{
    static int ReverseNumber(int number)
    {
        string raw = number.ToString();
        string reversedRaw = string.Empty;
        for (int i = raw.Length - 1; i >= 0; i--)
        {
            reversedRaw += raw[i];
        }

        return int.Parse(reversedRaw);
    }
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);

        Console.WriteLine(reversedNumber);
    }
}
