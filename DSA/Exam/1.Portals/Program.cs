namespace _1.Portals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static int[,] labyrinth;
        static int maxPower = 0;

        static void Main()
        {
            var startPos = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var labDims = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            labyrinth = new int[labDims[0], labDims[1]];
            bool[,] visited = new bool[labDims[0], labDims[1]];

            for (int row = 0; row < labyrinth.GetLength(0); row++)
            {
                string[] currentLine = Console.ReadLine().Split(' ');
                for (int col = 0; col < labyrinth.GetLength(1); col++)
                {
                    if (currentLine[col] == "#")
                    {
                        labyrinth[row, col] = -1;
                    }
                    else
                    {
                        labyrinth[row, col] = int.Parse(currentLine[col]);
                    }
                }
            }

            Teleport(visited, startPos[0], startPos[1], 0);

            Console.WriteLine(maxPower);
        }

        static void Teleport(bool[,] visited, int row, int col, int power)
        {
            // Out of lab row
            if (row >= labyrinth.GetLength(0) || row < 0)
            {
                return;
            }

            // Out of lab col
            if (col >= labyrinth.GetLength(1) || col < 0)
            {
                return;
            }

            // Take power
            int currentPower = labyrinth[row, col];

            if (currentPower < 0)
            {
                return;
            }

            // Check if Visited or frogs
            if (visited[row, col])
            {
                if (power > maxPower)
                {
                    maxPower = power;
                }

                return;
            }

            int totalPower = power + currentPower;

            visited[row, col] = true;
            Teleport(visited, row + currentPower, col, totalPower);
            Teleport(visited, row - currentPower, col, totalPower);
            Teleport(visited, row, col + currentPower, totalPower);
            Teleport(visited, row, col - currentPower, totalPower);
            visited[row, col] = false;

        }
    }
}
