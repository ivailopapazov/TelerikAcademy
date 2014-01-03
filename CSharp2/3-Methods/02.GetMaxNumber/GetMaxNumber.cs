using System;

class GetMaxNumber
{
    static int GetMax(int firstNum, int secondNum)
    {
        if (firstNum >= secondNum)
        {
            return firstNum;
        }
        else
        {
            return secondNum;
        }
    }

    static void Main()
    {
        // User Input
        Console.Write("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        // Solution
        int biggestNumber = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);

        // Printing Result
        Console.WriteLine(biggestNumber);
    }
}
