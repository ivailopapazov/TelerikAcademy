using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

class FallingRocks
{
    struct Element
    {
        public int posX;
        public int posY;
        public char symbol;
        public int density;
        public ConsoleColor color;
    }
    static void Main()
    {
        // Game Constants
        const int windowHeight = 20;
        const int windowWidth = 50;
        const int fieldWidth = 30;
        const int level = 3;

        // Game settings
        char[] rockSymbols = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        ConsoleColor[] colors = { ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Green, ConsoleColor.Gray, ConsoleColor.White, ConsoleColor.Magenta };
        int loopCounter = 0;
        bool rocked = false;
        int lives = 5;
        int score = 0;
       
        // Console window size
        Console.BufferHeight = Console.WindowHeight = windowHeight;
        Console.BufferWidth = Console.WindowWidth = windowWidth;

        // Set dwarf start position
        Element dwarf = new Element();
        dwarf.posX = (fieldWidth - 1) / 2;
        dwarf.posY = windowHeight - 1;
        
        // Empty list for the rocks
        List<Element> rocks = new List<Element>();
            
        // Infinite Loop
        while (true)
        {
            // Dwarf
            dwarf.symbol = '0';
            dwarf.color = ConsoleColor.Green;
            dwarf.density = 1;

            // Move dwarf
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.posX <= 0)
                    {
                        dwarf.posX = 0;
                    }
                    else
                    {
                        dwarf.posX--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.posX >= fieldWidth - 3)
                    {
                        dwarf.posX = fieldWidth - 3;
                    }
                    else
                    {
                        dwarf.posX++;
                    }
                }
                // Clearing the buffer
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
            }

            // Move rocks
            List<Element> movedRocks = new List<Element>();
            foreach (Element rock in rocks)
            {
                Element movedRock = new Element();
                movedRock = rock;
                // Check if rock is hitting the dwarf
                if (dwarf.posX - movedRock.density + 1 <= movedRock.posX && movedRock.posX <= dwarf.posX + 2 && dwarf.posY == movedRock.posY)
                {
                    rocked = true;
                }
                if (movedRock.posY < windowHeight - 1)
                {
                    movedRock.posY++;
                    movedRocks.Add(movedRock);
                }
                else
                {
                    score += movedRock.density;
                    movedRocks.Remove(movedRock);
                }
            }
            rocks = movedRocks;

            // Generate rocks
            if (loopCounter % level == 0)
            {
                Element newRock = new Element();
                Random randomNumber = new Random();
                newRock.posY = 0;
                newRock.posX = randomNumber.Next(0, fieldWidth);
                newRock.symbol = rockSymbols[randomNumber.Next(0, rockSymbols.Count())];
                newRock.color = colors[randomNumber.Next(0, colors.Count())];
                newRock.density = randomNumber.Next(1, 4);
                while (fieldWidth - (newRock.posX + newRock.density) < 0)
                {
                    newRock.density--;
                }
                
                rocks.Add(newRock);
                loopCounter = 0;
            }

            // Collision Detection
            if (rocked)
            {
                dwarf.symbol = 'X';
                dwarf.color = ConsoleColor.Red;
                dwarf.density = 3;
                rocks.Clear();
                rocked = false;
                lives--;
            }
            
            // Clear field
            Console.Clear();

            // Draw field
            DrawElement(dwarf.posX, dwarf.posY, dwarf.symbol, dwarf.color, dwarf.density); // Drawing dwarf
            for (int i = 0; i < windowHeight; i++) // Drawing field line
            {
                DrawElement(fieldWidth, i, '|', ConsoleColor.DarkYellow);
            }
            foreach (Element rock in rocks) // Draw rocks
            {
                DrawElement(rock.posX, rock.posY, rock.symbol, rock.color, rock.density);
            }
            if (lives >= 0)
            {
                DrawText(fieldWidth + 2, 2, "Score: " + score, ConsoleColor.White);
                DrawText(fieldWidth + 2, 3, "Lives: " + lives, ConsoleColor.White);
            }
            else
            {
                DrawText(fieldWidth / 3, windowHeight / 2, "GAME OVER!!!", ConsoleColor.Red);
                DrawText(fieldWidth / 4, windowHeight / 2 + 2, "Your score is: " + score, ConsoleColor.White);
                Console.SetCursorPosition(0, windowHeight - 1);
                return;
            }
            
            // Slow loop cycle
            Thread.Sleep(150);

            // Count loop cycles
            loopCounter++;
        }
    }
    static void DrawElement(int x, int y, char symbol, ConsoleColor color, int repeatElement = 1)
    {
        Console.SetCursorPosition(x, y);
        for (int i = 0; i < repeatElement; i++)
        {
            Console.ForegroundColor = color;
            if (symbol == '0')
            {
                Console.Write("(0)");
            }
            else
            {
                Console.Write(symbol);
            }
        }
    }
    static void DrawText(int x, int y, string text, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(text);
    }
}
