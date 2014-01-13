using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rowWidth = 2 * n - 3;
        int middleCol = rowWidth / 2;

        for (int i = 0; i < n; i++)
        {
            char[] blankRow = new string('.', rowWidth).ToArray();
            int startCol = middleCol - i;

            if (i != n - 1)
            {
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    blankRow[startCol + j] = '*';
                }
            }
            else
            {
                blankRow[middleCol] = '*';
            }
            Console.WriteLine(new string(blankRow));
        }
    }
}
