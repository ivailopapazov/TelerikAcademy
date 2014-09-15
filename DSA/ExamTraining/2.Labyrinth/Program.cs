namespace _2.Labyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        static void Main()
        {
            var startPos = Array.ConvertAll(Console.ReadLine().Split(' '), byte.Parse);
            var labyrinthDimensions = Array.ConvertAll(Console.ReadLine().Split(' '), byte.Parse);
            byte level = labyrinthDimensions[0];
            byte row = labyrinthDimensions[1];
            byte col = labyrinthDimensions[2];



            bool[,,] visited = new bool[level, row, col]; // L R C

            char[, ,] board = new char[level, row, col];
            for (int l = 0; l < board.GetLength(0); l++)
            {
                for (int r = 0; r < board.GetLength(1); r++)
                {
                    string currentRow = Console.ReadLine();
                    for (int c = 0; c < board.GetLength(2); c++)
                    {
                        board[l, r, c] = currentRow[c];
                    }
                }
            }

            Cell startCell = new Cell(startPos[0], startPos[1], startPos[2], 0);
            Queue<Cell> queue = new Queue<Cell>();
            queue.Enqueue(startCell);

            while (queue.Count != 0)
            {
                var currentCell = queue.Dequeue();

                if (board[currentCell.Level, currentCell.Row, currentCell.Col] == '#')
                {
                    continue;
                }

                // Left
                if (currentCell.Col > 0 && !visited[currentCell.Level, currentCell.Row, currentCell.Col - 1])
                {
                    var newCell = new Cell(currentCell.Level, currentCell.Row, (byte)(currentCell.Col - 1), currentCell.Steps + 1);
                    queue.Enqueue(newCell);
                    visited[newCell.Level, newCell.Row, newCell.Col] = true;
                }

                if (currentCell.Col < col - 1 && !visited[currentCell.Level, currentCell.Row, currentCell.Col + 1])
                {
                    var newCell = new Cell(currentCell.Level, currentCell.Row, (byte)(currentCell.Col + 1), currentCell.Steps + 1);
                    queue.Enqueue(newCell);
                    visited[newCell.Level, newCell.Row, newCell.Col] = true;
                }

                if (currentCell.Row > 0 && !visited[currentCell.Level, currentCell.Row - 1, currentCell.Col])
                {
                    var newCell = new Cell(currentCell.Level, (byte)(currentCell.Row - 1), currentCell.Col, currentCell.Steps + 1);
                    queue.Enqueue(newCell);
                    visited[newCell.Level, newCell.Row, newCell.Col] = true;
                }

                if (currentCell.Row < row - 1 && !visited[currentCell.Level, currentCell.Row + 1, currentCell.Col])
                {
                    var newCell = new Cell(currentCell.Level, (byte)(currentCell.Row + 1), currentCell.Col, currentCell.Steps + 1);
                    queue.Enqueue(newCell);
                    visited[newCell.Level, newCell.Row, newCell.Col] = true;
                }

                if (board[currentCell.Level, currentCell.Row, currentCell.Col] == 'U')
                {
                    if (currentCell.Level + 1 >= level)
                    {
                        Console.WriteLine(currentCell.Steps + 1);
                        break;
                    }

                    var newCell = new Cell((byte)(currentCell.Level + 1), currentCell.Row, currentCell.Col, currentCell.Steps + 1);
                    queue.Enqueue(newCell);
                    visited[newCell.Level, newCell.Row, newCell.Col] = true;
                }

                if (board[currentCell.Level, currentCell.Row, currentCell.Col] == 'D')
                {
                    if (currentCell.Level - 1 < 0)
                    {
                        Console.WriteLine(currentCell.Steps + 1);
                        break;
                    }

                    var newCell = new Cell((byte)(currentCell.Level - 1), currentCell.Row, currentCell.Col, currentCell.Steps + 1);
                    queue.Enqueue(newCell);
                    visited[newCell.Level, newCell.Row, newCell.Col] = true;
                }
            }
        }
    }

    public class Cell
    {

        public Cell(byte level, byte row, byte col, int steps)
        {
            this.Row = row;
            this.Col = col;
            this.Level = level;
            this.Steps = steps;
        }

        public byte Row { get; set; }

        public byte Col { get; set; }

        public byte Level { get; set; }

        public int Steps { get; set; }
    }
}
