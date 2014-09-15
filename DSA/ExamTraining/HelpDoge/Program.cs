namespace HelpDoge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            var fieldSize = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }), int.Parse);
            var foodLocation = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }), int.Parse);
            var enemyCount = int.Parse(Console.ReadLine());

            bool[,] enemyField = new bool[fieldSize[0], fieldSize[1]];
            BigInteger[,] field = new BigInteger[fieldSize[0], fieldSize[1]];

            for (int i = 0; i < enemyCount; i++)
            {
                var enemyLocation = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }), int.Parse);
                enemyField[enemyLocation[0], enemyLocation[1]] = true;
            }

            for (int row = 0; row <= foodLocation[0]; row++)
            {
                for (int col = 0; col <= foodLocation[1]; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        field[row, col] = 1;
                        continue;
                    }

                    if (enemyField[row, col])
                    {
                        field[row, col] = 0;
                        continue;
                    }

                    BigInteger waysToTravel = 0;

                    if (row > 0)
                    {
                        waysToTravel += field[row - 1, col];
                    }

                    if (col > 0)
                    {
                        waysToTravel += field[row, col - 1];
                    }

                    field[row, col] = waysToTravel;
                }
            }

            Console.WriteLine(field[foodLocation[0], foodLocation[1]]);
        }
    }
}
