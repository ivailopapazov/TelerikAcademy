using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int middle = n / 2;
        int dotsCount = 0;
        int starsCount = n;

        for (int i = 0; i < n; i++)
        {
            string dots = new string('.', dotsCount);
            string stars = new string ('*', starsCount);

            Console.WriteLine("{0}{1}{0}", dots, stars);
            if (i < middle)
            {
                dotsCount++;
                starsCount -= 2; ;
            }
            else
            {
                dotsCount--;
                starsCount += 2;
            }
        }
    }
}
