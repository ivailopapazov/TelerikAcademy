using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ApplyBonusScore
{
    static void Main()
    {
        int score = 0;
        Console.Write("Enter the score: ");

        if (int.TryParse(Console.ReadLine(), out score))
        {
            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Your score with bonus is {0}", score *= 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Your score with bonus is {0}", score *= 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Your score with bonus is {0}", score *= 1000);
                    break;
                default:
                    Console.WriteLine("Not in score range!!!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Not a number!!!");
        }
    }
}
