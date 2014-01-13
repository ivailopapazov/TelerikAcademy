using System;

class SignOfProduct
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        char productSign;

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0) // if one of numbers is zero than the product is zero
        {
            productSign = '0';
        }
        else if ((firstNumber < 0 ^ secondNumber < 0) ^ thirdNumber > 0) // all cases with positive product
        {
            productSign = '+';
        }
        else { // else are cases with negative product
            productSign = '-';
        }

        Console.WriteLine("The sign of the product of {0}, {1} and {2} is {3}", firstNumber, secondNumber, thirdNumber, productSign);
    }
}
