using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] number = new int[n];

        for (int i = 0; i < n; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            int pNew = 0;
            while (true)
            {
                pNew += number[i] & 1;
                number[i] >>= 1;
                if (number[i] != 0)
                {
                    pNew <<= 1;
                }
                else
                {
                    Console.WriteLine(pNew);
                    break;
                }
            }
        }
    }
}
