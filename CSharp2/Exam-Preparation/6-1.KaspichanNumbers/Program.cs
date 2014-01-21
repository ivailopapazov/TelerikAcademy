using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // input
        ulong number = ulong.Parse(Console.ReadLine());

        // Create kaspichan digits list
        List<string> digits = new List<string>();

        for (char i = 'A'; i <= 'Z'; i++)
        {
            digits.Add(i.ToString());
        }
        for (char i = 'a'; i <= 'i'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                digits.Add(i.ToString() + j.ToString() );
            }
        }

        // Declaration
        List<string> kaspichanNumber = new List<string>();
 
        // Convert to kaspichan
        while (number != 0)
        {
            int remainder = (int)(number % 256);
            number /= 256;
            kaspichanNumber.Add(digits[remainder]);
        }

        kaspichanNumber.Reverse();

        if (kaspichanNumber.Count == 0)
        {
            Console.WriteLine("A");
        }
        else
        {
            Console.WriteLine(string.Join("", kaspichanNumber));
        }
    }
}
