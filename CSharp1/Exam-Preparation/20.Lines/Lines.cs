using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Lines
{
    static void Main()
    {
        int[] number = new int[8];

        int maxLine = 0;
        int countLines = 0;

        for (int i = 0; i < 8; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
            int currentLine = 0;

            for (int j = 0; j < 8; j++)
            {
                if ((number[i] & (1 << j)) != 0)
                {
                    currentLine++;
                    if (currentLine > maxLine)
                    {
                        maxLine = currentLine;
                        countLines = 1;
                    }
                    else if (currentLine == maxLine)
                    {
                        countLines++;
                    }
                }
                else
                {
                    currentLine = 0;
                }
            }
        }

        for (int j = 0; j < 8; j++)
        {
            int currentLine = 0;
            for (int i = 0; i < 8; i++)
            {
                if ((number[i] & (1 << j)) != 0)
                {
                    currentLine++;
                    if (currentLine > maxLine)
                    {
                        maxLine = currentLine;
                        countLines = 1;
                    }
                    else if (currentLine == maxLine)
                    {
                        countLines++;
                    }
                }
                else
                {
                    currentLine = 0;
                }
            }
        }
        if (maxLine == 1)
        {
            countLines /= 2;
        }
        Console.WriteLine(maxLine);
        Console.WriteLine(countLines);
    }
}
