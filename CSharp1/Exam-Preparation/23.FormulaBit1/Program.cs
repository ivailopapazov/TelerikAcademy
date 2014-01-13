using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] square = new int[8];
        int length = 1;
        int turns = 0;

        int currentDirection = 0;
        int lastDirection = 0;

        for (int i = 0; i < 8; i++)
        {
            square[i] = int.Parse(Console.ReadLine());
        }

        int row = 0;
        int col = 0;

        while (true)
        {
            if (currentDirection != lastDirection)
            {
                turns++;
                lastDirection = currentDirection;
            }

            if ((square[row+1] & (1 << col)) == 0 && row < 7 && lastDirection != 2) // South Movement
            {
                currentDirection = 0;
                row++;
                length++;
            }
            else if ((square[row] & (1 << (col + 1))) == 0 && col < 7) // West Movement
            {
                currentDirection = 1;
                col++;
                length++;
            }
            else if ((square[row-1] & (1 << col)) == 0 && row > 0) // North Movement
            {
                currentDirection = 2;
                row--;
                length++;
            }
            else if (col == 7 && row == 7) // Finish line
            {
                Console.WriteLine("{0} {1}", length, turns);
                break;
            }
            else // No path is available
            {
                Console.WriteLine("No " + turns);
                break;
            }
        }
    }
}
