using System;
using System.Collections.Generic;

class CheckBrackets
{
    static bool CheckExpression(string expression, int index = 0)
    {
        // Left brackets count
        int brackets = 0;

        while (index < expression.Length)
        {
            index = expression.IndexOfAny(new char[] { '(', ')' }, index);
            if (index < 0)
            {
                // Stop if no more brackets left
                break;
            }
            else if (expression[index] == '(')
            {
                // Add left bracket
                brackets++;
            }
            else
            {
                // If right bracket is found and there are left brackets;
                if (brackets > 0)
                {
                    // Substrackt left bracket
                    brackets--;
                }
                else
                {
                    return false;
                }
            }

            // Next index
            index++;
        }

        // If all left brackets are canceld
        if (brackets == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        // User input
        Console.Write("Enter an expression: ");
        string expression = Console.ReadLine();

        // Check brackets
        bool result = CheckExpression(expression);

        // Print result
        Console.WriteLine(result);
    }
}
