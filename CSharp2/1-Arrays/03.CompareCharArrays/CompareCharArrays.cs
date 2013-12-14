using System;

class CompareCharArrays
{
    static void Main()
    {
        // User input 
        Console.Write("Please enter the first string: ");
        string firstString = Console.ReadLine();
        Console.Write("Please enter the second string: ");
        string secondString = Console.ReadLine();
        
        // Remove uppercase
        firstString = firstString.ToLower();
        secondString = secondString.ToLower();

        // Equalize the string lengths with spaces (lowest lexicographic order count)
        if (firstString.Length > secondString.Length)
        {
            secondString = secondString.PadRight(firstString.Length);
        }
        else if (secondString.Length > firstString.Length)
        {
            firstString = firstString.PadRight(secondString.Length);
        }

        // Compare strings element wise
        for (int i = 0; i < firstString.Length; i++)
        {
            if (firstString[i] < secondString[i])
            {
                Console.WriteLine("{0} < {1}", firstString, secondString);
                break;
            }
            else if (firstString[i] > secondString[i])
            {
                Console.WriteLine("{0} < {1}", secondString, firstString);
                break;
            }
        }
    }
}
