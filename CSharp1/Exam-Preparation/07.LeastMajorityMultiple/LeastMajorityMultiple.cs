using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LeastMajorityMultiple
{
    static void Main()
    {
        int[] numberSet = new int[5];
        
        int exactDivisions = 0;
        int multiple = 2;

        for (int i = 0; i < 5; i++)
        {
            numberSet[i] = int.Parse(Console.ReadLine());
        }

        while (true)
        {
            for (int i = 0; i < 5; i++)
            {
                if (multiple % numberSet[i]== 0)
                {
                    exactDivisions++;
                }
            }
            if (exactDivisions > 2)
            {
                Console.WriteLine(multiple);
                break;
            }
            multiple++;
            exactDivisions = 0;
        }
    }
}
