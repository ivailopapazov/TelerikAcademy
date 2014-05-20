using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Minesweeper
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] board = CreateBoard();
            char[,] mines = PlaceMines();
            int counter = 0;
            bool isDead = false;
            List<Score> hiScore = new List<Score>(6);
            int row = 0;
            int col = 0;
            bool isPlayersTurn = true;
            const int MaxBoxes = 35;
            bool isWinner = false;

            do
            {
                if (isPlayersTurn)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    DrawBoard(board);
                    isPlayersTurn = false;
                }
                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= board.GetLength(0) && col <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        ScoreTable(hiScore);
                        break;
                    case "restart":
                        board = CreateBoard();
                        mines = PlaceMines();
                        DrawBoard(board);
                        isDead = false;
                        isPlayersTurn = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                PlayerMove(board, mines, row, col);
                                counter++;
                            }
                            if (MaxBoxes == counter)
                            {
                                isWinner = true;
                            }
                            else
                            {
                                DrawBoard(board);
                            }
                        }
                        else
                        {
                            isDead = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }
                if (isDead)
                {
                    DrawBoard(mines);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", counter);
                    string nickname = Console.ReadLine();
                    Score t = new Score(nickname, counter);
                    if (hiScore.Count < 5)
                    {
                        hiScore.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < hiScore.Count; i++)
                        {
                            if (hiScore[i].Points < t.Points)
                            {
                                hiScore.Insert(i, t);
                                hiScore.RemoveAt(hiScore.Count - 1);
                                break;
                            }
                        }
                    }
                    hiScore.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    hiScore.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    ScoreTable(hiScore);

                    board = CreateBoard();
                    mines = PlaceMines();
                    counter = 0;
                    isDead = false;
                    isPlayersTurn = true;
                }
                if (isWinner)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    DrawBoard(mines);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    Score to4kii = new Score(imeee, counter);
                    hiScore.Add(to4kii);
                    ScoreTable(hiScore);
                    board = CreateBoard();
                    mines = PlaceMines();
                    counter = 0;
                    isWinner = false;
                    isPlayersTurn = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void ScoreTable(List<Score> to4kii)
        {
            Console.WriteLine("\nTo4KI:");
            if (to4kii.Count > 0)
            {
                for (int i = 0; i < to4kii.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, to4kii[i].Name, to4kii[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void PlayerMove(char[,] board,
            char[,] mines, int row, int col)
        {
            char minesCount = CountMines(mines, row, col);
            mines[row, col] = minesCount;
            board[row, col] = minesCount;
        }

        private static void DrawBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] board = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!mines.Contains(randomNumber))
                {
                    mines.Add(randomNumber);
                }
            }

            foreach (int mine in mines)
            {
                int col = (mine / cols);
                int row = (mine % cols);
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }
                board[col, row - 1] = '*';
            }

            return board;
        }

        private static char CountMines(char[,] board, int col, int row)
        {
            int count = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (col - 1 >= 0)
            {
                if (board[col - 1, row] == '*')
                {
                    count++;
                }
            }
            if (col + 1 < rows)
            {
                if (board[col + 1, row] == '*')
                {
                    count++;
                }
            }
            if (row - 1 >= 0)
            {
                if (board[col, row - 1] == '*')
                {
                    count++;
                }
            }
            if (row + 1 < cols)
            {
                if (board[col, row + 1] == '*')
                {
                    count++;
                }
            }
            if ((col - 1 >= 0) && (row - 1 >= 0))
            {
                if (board[col - 1, row - 1] == '*')
                {
                    count++;
                }
            }
            if ((col - 1 >= 0) && (row + 1 < cols))
            {
                if (board[col - 1, row + 1] == '*')
                {
                    count++;
                }
            }
            if ((col + 1 < rows) && (row - 1 >= 0))
            {
                if (board[col + 1, row - 1] == '*')
                {
                    count++;
                }
            }
            if ((col + 1 < rows) && (row + 1 < cols))
            {
                if (board[col + 1, row + 1] == '*')
                {
                    count++;
                }
            }
            return char.Parse(count.ToString());
        }
    }
}
