using System;
using System.Collections.Generic;
using System.IO;

// http://bgcoder.com/Contests/Submissions/View/283153

class Program
{
    static int[] ReadNumbers()
    {
        return Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    }

    static int[] GetNewPosition(int[] oldPosition, int[] dir)
    {
        int[] newPosition = new int[3];
        for (int i = 0; i < oldPosition.Length; i++)
        {
            newPosition[i] = oldPosition[i] + dir[i];
        }

        return newPosition;
    }

    static int CheckBorder(int[] dim, int[] pos)
    {
        int border = 0;
        for (int i = 0; i < dim.Length; i++)
        {
            if (pos[i] == dim[i] || pos[i] == 1)
            {
                border++;
            }
        }
        return border;
    }
    static void Main(string[] args)
    {
        //Console.SetIn(new StreamReader("input.txt"));

        // Input
        int[] dim = ReadNumbers();
        bool[, ,] cube = new bool[dim[0] + 1, dim[1] + 1, dim[2] + 1];

        int[] pos = ReadNumbers();
        int[] dir = ReadNumbers();

        // setting burned cubes
        cube[pos[0], pos[1], pos[2]] = true;

        while (true)
        {
            // Move position
            int[] newPos = GetNewPosition(pos, dir);

            // Check border
            int border = CheckBorder(dim, newPos);

            // if newPos is vertex, edge or visited
            if (border > 1 || cube[newPos[0], newPos[1], newPos[2]])
            {
                // laser ends
                Console.WriteLine(string.Join(" ", pos));
                break;
            }
            else if (border == 1)
            {
                // change dir
                for (int i = 0; i < 3; i++)
                {
                    if (newPos[i] == 1 || newPos[i] == dim[i])
                    {
                        dir[i] = -dir[i];
                    }
                }

            }
            pos = (int[])newPos.Clone();
            cube[pos[0], pos[1], pos[2]] = true;
        }
    }
}
