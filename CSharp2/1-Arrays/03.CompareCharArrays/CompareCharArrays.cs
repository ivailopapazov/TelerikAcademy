using System;

class CompareCharArrays
{
    static void Main()
    {
        // User input 
        Console.Write("Please enter the first word: ");
        char[] firstArray = Console.ReadLine().ToLower().ToCharArray();
        Console.Write("Please enter the second word: ");
        char[] secondArray = Console.ReadLine().ToLower().ToCharArray();
        
        // Find the shorter length
        int length = Math.Min(firstArray.Length, secondArray.Length);

        // Compare arrays element wise
        for (int i = 0; i < length; i++)
        {
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("{0} is lexicographically first", new string(firstArray));
                return;
            }
            else if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("{0} is lexicographically first", new string(secondArray));
                return;
            }
        }

        // Compare arrays by length if elements are the same
        if (firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("{0} is lexicographically first", new string(firstArray));
        }
        else if (secondArray.Length < firstArray.Length)
        {
            Console.WriteLine("{0} is lexicographically first", new string(secondArray));
        }
        else
        {
            Console.WriteLine("The words are lexicographically the same");
        }
    }
}
