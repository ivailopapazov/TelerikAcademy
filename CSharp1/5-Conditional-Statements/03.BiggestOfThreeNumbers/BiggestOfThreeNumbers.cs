using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggestNumber = 0; // Container for the biggest number

        // Pretty much self explanatory
        if (firstNumber >= secondNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                biggestNumber = firstNumber;
            }
            else
            {
                biggestNumber = thirdNumber;
            }
        }
        else
        {
            if (secondNumber >= thirdNumber)
            {
                biggestNumber = secondNumber;
            }
            else
            {
                biggestNumber = thirdNumber;
            }
        }

        Console.WriteLine("The biggest number is {0}", biggestNumber);

    }
}
