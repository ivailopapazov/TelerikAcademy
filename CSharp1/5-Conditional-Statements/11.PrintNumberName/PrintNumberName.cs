using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For this task I use UK number name standard. For more info: http://www.mathsisfun.com/numbers/counting-names-1000.html
class PrintNumberName
{
    static void Main()
    {
        int number = 0;
        do
        {
            Console.Write("Please enter a number [0-999]: ");
        } while (int.TryParse(Console.ReadLine(), out number) == false && number > 999 || number > 999 || number < 0);
        
        int[] digits = IntToArray(number); // Split the number into digit array

        // Declare variables
        string name = "";
        string carrier = "";

        // Loop for every digit in the number
        for (int i = 0; i < digits.Count(); i++)
		{
            // Hundreds
            if (i == digits.Count() - 3) 
            {
                name = GetDigitName(digits[i]);
                name += " hundred";
                carrier = " and "; // "and" must be carried if there are more non-zero digits in the number.
            }
            // Tens
            else if (i == digits.Count() - 2)
            {
                if (digits[i] > 1) 
                {
                    name += carrier;
                    name += GetDigitName(digits[i] * 10);
                    carrier = "-"; // "-" must be carried if there is non-zero ones digit.
                }
                else if (digits[i] == 1)
                {
                    name += carrier;
                    carrier = "teen"; // key word is carried to indicate for number in [10; 19] range
                }
                // else when equals 0. Do nothing, just carry the carrier (and)
            }
            // Ones
            else if (i == digits.Count() - 1) 
            {
                if (carrier == "teen")
                {
                    name += GetDigitName(digits[i] + 10);
                }
                else if (digits[i] != 0)
                {
                    name += carrier;
                    name += GetDigitName(digits[i]);
                }
            }
        }
        // First letter is converted to upper and prints the name of the number.
        Console.WriteLine(char.ToUpper(name[0]) + name.Substring(1));

    }
    public static int[] IntToArray(int num)
    {

        List<int> digitArray = new List<int>();

        do
        {
            digitArray.Add(num % 10);
            num /= 10;
        }
        while (num != 0);

        digitArray.Reverse();
        return digitArray.ToArray();
    }
    public static string GetDigitName(int num)
    {
        string name = "";

        // Every possible unique digit or number name in the range.
        switch (num)
        {
            case 0:
                name = "zero";
                break;
            case 1:
                name = "one";
                break;
            case 2:
                name = "two";
                break;
            case 3:
                name = "three";
                break;
            case 4:
                name = "four";
                break;
            case 5:
                name = "five";
                break;
            case 6:
                name = "six";
                break;
            case 7:
                name = "seven";
                break;
            case 8:
                name = "eight";
                break;
            case 9:
                name = "nine";
                break;
            case 10:
                name = "ten";
                break;
            case 11:
                name = "eleven";
                break;
            case 12:
                name = "twelve";
                break;
            case 13:
                name = "thirteen";
                break;
            case 14:
                name = "fourteen";
                break;
            case 15:
                name = "fifteen";
                break;
            case 16:
                name = "sixteen";
                break;
            case 17:
                name = "seventeen";
                break;
            case 18:
                name = "eighteen";
                break;
            case 19:
                name = "nineteen";
                break;
            case 20:
                name = "twenty";
                break;
            case 30:
                name = "thirty";
                break;
            case 40:
                name = "forty";
                break;
            case 50:
                name = "fifty";
                break;
            case 60:
                name = "sixty";
                break;
            case 70:
                name = "seventy";
                break;
            case 80:
                name = "eighty";
                break;
            case 90:
                name = "ninety";
                break;
        }
        return name;
    }
}
