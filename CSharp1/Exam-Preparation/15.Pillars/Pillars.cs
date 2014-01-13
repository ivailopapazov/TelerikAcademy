using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pillars
{
    static void Main()
    {
        int[] columnBits = new int[8];
        bool noPillar = true;

        for (int i = 0; i < 8; i++)
        {
            int input = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                if ((input & 1) == 1)
                {
                    columnBits[j]++;
                }
                else if (input == 0)
                {
                    break;
                }
                input >>= 1;
            }
        }

        for (int pillar = 7; pillar >= 0; pillar--)
        {
            int leftBits = 0;
            int rightBits = 0;

            // Left pillars
            for (int l = 7; l > pillar; l--)
            {
                leftBits += columnBits[l];
            }

            // Right pillars
            for (int r = 0; r < pillar; r++)
            {
                rightBits += columnBits[r];
            }

            if (leftBits == rightBits)
            {
                Console.WriteLine(pillar);
                Console.WriteLine(leftBits);
                noPillar = false;
                break;
            }
        }

        if (noPillar)
        {
            Console.WriteLine("No");
        }
    }
}
