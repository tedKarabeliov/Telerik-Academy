using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace SokobanGame
{
    public class Sokoban
    {
        public static int level;

        public static void ReadLevelInfo(int level)
        {
            try
            {
                string path = @"..\..\Level" + level + ".txt";
                StreamReader reader = new StreamReader(path);

                using (reader)
                {
                    string[] boardDimentions = reader.ReadLine().Split(' ');

                    int rows = int.Parse(boardDimentions[0]);
                    int cols = int.Parse(boardDimentions[1]);

                    board = new char[rows, cols];

                    for (int row = 0; row < rows; row++)
                    {
                        string line = reader.ReadLine();

                        for (int col = 0; col < cols; col++)
                        {
                            board[row, col] = line[col];
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

        }

        public static void PrintBoard()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                Console.SetCursorPosition(2, row + 4);

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    PrintSymbol(board[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void PrintSymbol(char symbol)
        {
            if (symbol == ' ')
            {
                Console.Write(' ');
            }
            else if (symbol == '@')
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write('@');
            }
            else if (symbol == '$')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write('$');
            }
            else if (symbol == '.')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write('.');
            }
            else if (symbol == '#')
            {
                Console.ResetColor();
                Console.Write('#');
            }
        }

        public static int[] FindPlayerStartPosition()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == '@')
                    {
                        int[] positions = new int[2];
                        positions[0] = row;
                        positions[1] = col;
                        return positions;
                    }
                }
            }
            return new int[0];
        }

        /// <summary>
        ///  add the coordinates of the dots on the board
        ///  on even positions in the list is the row position
        ///  on odd positions in the list is the col position
        /// </summary>
        public static void GetDotsPositions()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == '.')
                    {
                        boardDotsCoordinates.Add(row);
                        boardDotsCoordinates.Add(col);
                    }
                }
            }
        }

        private static bool IsLevelCleared()
        {
            for (int i = 0; i < boardDotsCoordinates.Count; i += 2)
            {
                if (board[boardDotsCoordinates[i], boardDotsCoordinates[i + 1]] != '$')
                {
                    return false;
                }
            }
            return true;
        }

        private static void SetBufferSize()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.CursorVisible = false;
        }

        private static void PrintGameInfo(int movesCount)
        {
            Console.SetCursorPosition(board.GetLength(0) / 2 + 2, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Level " + level);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(board.GetLength(1) + 10, board.GetLength(0) / 4 + 3);
            Console.WriteLine("To restart: R");

            Console.SetCursorPosition(board.GetLength(1) + 10, board.GetLength(0) / 4 + 6);
            Console.WriteLine("To exit: E");

            Console.SetCursorPosition(board.GetLength(1) + 10, board.GetLength(0) / 4 + 9);
            Console.WriteLine("Moves count: {0}", movesCount);
        }

        private static bool Menu()
        {
            while (true)
            {
                Console.CursorVisible = false;
                Console.Clear();
                Console.WriteLine("Sokoban");
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Level choice");
                Console.WriteLine("3. Game info");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.WriteLine("Use the keys (0-9) to navigate throug the menu:");

                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.D1 || pressedKey.Key == ConsoleKey.NumPad1)
                {
                    level = 1;
                    return true;
                }
                else if (pressedKey.Key == ConsoleKey.D2 || pressedKey.Key == ConsoleKey.NumPad2)
                {
                    if (LevelMenu())
                    {
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.D3 || pressedKey.Key == ConsoleKey.NumPad3)
                {
                    if (InfoMenu())
                    {
                        continue;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.D4 || pressedKey.Key == ConsoleKey.NumPad4)
                {
                    Console.WriteLine();
                    Console.WriteLine("You chose to exit.");
                    Console.WriteLine();
                }
                else
                {
                    continue;
                }

                return false;
            }
        }

        private static bool LevelMenu()
        {
            while (true)
            {
                Console.CursorVisible = false;
                Console.Clear();
                Console.WriteLine("0. Go back");
                Console.WriteLine("1. Level 1");
                Console.WriteLine("2. Level 2");
                Console.WriteLine();
                Console.WriteLine("Use the keys (0-9) to navigate throug the menu:");

                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.D0 || pressedKey.Key == ConsoleKey.NumPad0)
                {
                    return false;
                }
                else if (pressedKey.Key == ConsoleKey.D1 || pressedKey.Key == ConsoleKey.NumPad1)
                {
                    level = 1;
                    return true;
                }
                else if (pressedKey.Key == ConsoleKey.D2 || pressedKey.Key == ConsoleKey.NumPad2)
                {
                    level = 2;
                    return true;
                }
                else
                {
                    continue;
                }
            }
        }

        private static bool InfoMenu()
        {
            while (true)
            {
                Console.CursorVisible = false;
                Console.Clear();
                Console.WriteLine("Sokoban information:");
                Console.WriteLine("Sokoban is a type of transport puzzle, in which the player pushes boxes trying");
                Console.WriteLine("to get them to storage locations. In the game the storage locations are");
                Console.WriteLine("indicated with \".\" and the boxes with \"$\". The player itself is indicated with");
                Console.WriteLine(" \"@\". Use the arrow keys to control the player and navigate throug the level.");
                Console.WriteLine();
                Console.WriteLine("0. Go back.");

                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.D0 || pressedKey.Key == ConsoleKey.NumPad0)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
           
        }

        public static List<int> boardDotsCoordinates = new List<int>();
        public static char[,] board;
        const int maxLevel = 2;
        static void Main()
        {
            if (Menu())
            {
                while (level <= maxLevel)
                {
                    ReadLevelInfo(level);
                    GetDotsPositions();
                    SetBufferSize();
                    //playerStartPosition[0] - > row
                    //playerStartPosition[1] - > col
                    int[] playerStartPosition = FindPlayerStartPosition();

                    Player player = new Player(playerStartPosition[0], playerStartPosition[1]);
                    Console.Clear();
                    PrintGameInfo(player.PlayerMovesCount);
                    PrintBoard();
                    while (true)
                    {
                        if (!player.CanProcessCommand(board))
                        {
                            continue;
                        }

                        PrintGameInfo(player.PlayerMovesCount);

                        if (IsLevelCleared())
                        {
                            Console.SetCursorPosition(0, board.GetLength(0) + 5);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Level clear !");
                            if (level < maxLevel)
                            {
                                Console.WriteLine("You will be automatically transfered to next level.");
                            }
                            else
                            {
                                Console.WriteLine("Congratulations! You cleared all levels!");
                            }
                            Console.Beep(2000, 300);
                            Console.Beep(2000, 300);
                            Console.Beep(2000, 300);
                            Thread.Sleep(500);
                            break;
                        }
                    }
                    level++;
                }
            }
        }
    }
}
