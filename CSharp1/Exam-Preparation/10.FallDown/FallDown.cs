using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FallDown
{
    static void Main()
    {
        int[] square = new int[8];

        // Input values
        for (int i = 0; i < 8; i++)
        {
            square[i] = int.Parse(Console.ReadLine());
        }

        // Rows
        for (int rowNumber = 7; rowNumber > 0; rowNumber--)
        {
            for (int col = 0; col < 8; col++)
            {
                int bit = 1 << col;
                for (int row = rowNumber - 1; row >= 0; row--)
                {
                    if ((square[rowNumber] & bit) == 0 && (square[row] & bit) != 0)
                    {
                        square[rowNumber] |= bit;
                        square[row] &= ~bit;
                        break;
                    }
                }
            }
        }
        // Print sqare
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(square[i]);
        }
    }
}
