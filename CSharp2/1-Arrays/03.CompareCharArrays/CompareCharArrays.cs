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
        
        // Find the longest string length
        int length = Math.Max(firstString.Length, secondString.Length);

        // Remove uppercase, equalize string lengths with spaces, convert to char array 
        char[] firstArray = firstString.ToLower().PadRight(length).ToCharArray();
        char[] secondArray = secondString.ToLower().PadRight(length).ToCharArray();
        
        // Compare arrays element wise
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("{0} is lexicographically first", firstString);
                break;
            }
            else if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("{0} is lexicographically first", secondString);
                break;
            }
        }
    }
}
