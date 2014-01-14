using System;

public class StringSum
{
    string inputString;
    int sum;

    public StringSum(string inputString)
    {
        this.inputString = inputString;
    }

    public int CalculateSum()
    {
        // Split the string into array of string numbers
        string[] stringNumbers = inputString.Split(' ');

        // Parse numbers and add to sum
        foreach (var number in stringNumbers)
        {
            sum += int.Parse(number);
        }

        // Return sum
        return sum;
    }
}
