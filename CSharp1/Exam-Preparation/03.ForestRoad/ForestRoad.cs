using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ForestRoad
{
    static void Main()
    {
        int mapWidth = int.Parse(Console.ReadLine());
        int mapHeight = (2 * mapWidth) - 1;

        string trees = new string('.', mapWidth);
        char[] forestRow = new char[mapWidth];
        int geekoPosition = 0;

        for (int i = 0; i < mapHeight; i++)
        {
            forestRow = trees.ToArray();
            forestRow[geekoPosition] = '*';
            Console.WriteLine(new string(forestRow));

            if (i < mapWidth - 1)
            {
                geekoPosition++;
            }
            else
            {
                geekoPosition--;
            }
            
        }
    }
}
