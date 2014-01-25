using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Doge
{
    class Program
    {
        public static int[,] grid;
        public static int coins = 0;
        public static int maxCoins = 0;
        static int[] ReadLine()
        {
            return Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        }
        static void Main(string[] args)
        {
            int[] dim = ReadLine();
            grid = new int[dim[0], dim[1]];
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                int[] coin = ReadLine();
                grid[coin[0], coin[1]]++;
            }

            Move(0, 0);
            Console.WriteLine(maxCoins);
        }
        static void Move(int row, int col)
        {
            // check for border
            if (row >= grid.GetLength(0) || col >= grid.GetLength(1))
            {
                return;
            }

            // check for end
            if (row == grid.GetLength(0) - 1 && col == grid.GetLength(1) - 1)
            {
                return;
            }

            //check for coin
            if (grid[row, col] > 0)
            {
                coins += grid[row, col];
            }

            if (coins > maxCoins)
            {
                maxCoins = coins;
            }

            // move
            Move(row, col + 1);
            Move(row + 1, col);

            // 
            if (grid[row, col] > 0)
            {
                coins -= grid[row, col];
            }
        }
    }
}
