using System;
using System.Collections.Generic;

namespace SokobanGame
{
    public class Player
    {
        private int positionX;
        private int positionY;
        private int playerMovesCount;
        public int PositionX
        {
            get { return this.positionX; }
            set { this.positionX = value; }
        }
        public int PositionY
        {
            get { return this.positionY; }
            set { this.positionY = value; }
        }
        public int PlayerMovesCount
        {
            get { return this.playerMovesCount; }
            set { this.playerMovesCount = value; }
        }
        public Player(int x, int y)
        {
            this.positionX = x;
            this.positionY = y;
        }

        public int GetPositionStatus(char[,] board, int posX, int posY)
        {
            if (board[posX, posY] == '#')
            {
                return 0; // wall
            }
            else if (board[posX, posY] == ' ')
            {
                return 1; // whitespace
            }
            else if (board[posX, posY] == '$')
            {
                return 2; // box
            }
            else if (board[posX, posY] == '.')
            {
                return 3; // place for box
            }
            throw new ArgumentException("Invalid symbol, check level text file!");
        }
        public void PrintLastPosition()
        {
            //if the last position was a dot, print it and set it to dot in the board
            for (int i = 0; i < Sokoban.boardDotsCoordinates.Count; i += 2)
            {
                if (Sokoban.boardDotsCoordinates[i] == this.positionX && Sokoban.boardDotsCoordinates[i + 1] == this.positionY)
                {
                    Sokoban.board[this.positionX, this.positionY] = '.';
                    Console.SetCursorPosition(this.positionY + 2, this.positionX + 4);
                    Sokoban.PrintSymbol('.');
                    return;
                }
            }

            //if it is not a dot than put a whitespace
            Sokoban.board[this.positionX, this.positionY] = ' ';
            Console.SetCursorPosition(this.positionY + 2, this.positionX + 4);
            Sokoban.PrintSymbol(' ');
        }
        public void UpMovement(int positionStatusNumber)
        {
            if (positionStatusNumber == 1 || positionStatusNumber == 3)
            {
                //we reach a valid position to move (on whitespace or on place for box)
                PrintLastPosition();
                this.positionX--;
                Sokoban.board[this.positionX, this.positionY] = '@';
                Console.SetCursorPosition(this.positionY + 2, this.positionX + 4);
                Sokoban.PrintSymbol('@');

                this.playerMovesCount++;
            }
            else if (positionStatusNumber == 2)
            {
                //we hit a box and check the position after the box
                int nextPositionStatusNumber = GetPositionStatus(Sokoban.board, this.positionX - 2, this.positionY);

                if (nextPositionStatusNumber == 0 || nextPositionStatusNumber == 2)
                {
                    //it is wall or a box so we can not move the box
                    return;
                }
                else
                {
                    //a whitespace or a place for box -> move the box
                    PrintLastPosition();

                    Sokoban.board[--this.positionX, this.positionY] = '@';
                    Console.SetCursorPosition(this.positionY + 2, this.positionX + 4);
                    Sokoban.PrintSymbol('@');

                    Sokoban.board[this.positionX - 1, this.positionY] = '$';
                    Console.SetCursorPosition(this.positionY + 2, this.positionX + 3);
                    Sokoban.PrintSymbol('$');

                    this.playerMovesCount++;
                }
            }
        }
        public void DownMovement(int positionStatusNumber)
        {
            if (positionStatusNumber == 1 || positionStatusNumber == 3)
            {
                //reach a valid position to move
                PrintLastPosition();

                this.positionX++;
                Sokoban.board[this.positionX, this.positionY] = '@';
                Console.SetCursorPosition(this.positionY + 2, this.positionX + 4);
                Sokoban.PrintSymbol('@');

                this.playerMovesCount++;
            }
            else if (positionStatusNumber == 2)
            {
                //hit a box and check the position after the box
                int nextPositionStatusNumber = GetPositionStatus(Sokoban.board, this.positionX + 2, this.positionY);

                if (nextPositionStatusNumber == 0 || nextPositionStatusNumber == 2)
                {
                    //it is a wall or a box so we can not move the box
                    return;
                }
                else
                {
                    //it is a whitespace or a place for box we move the box
                    PrintLastPosition();

                    Sokoban.board[++this.positionX, this.positionY] = '@';
                    Console.SetCursorPosition(this.positionY + 2, this.positionX + 4);
                    Sokoban.PrintSymbol('@');

                    Sokoban.board[this.positionX + 1, this.positionY] = '$';
                    Console.SetCursorPosition(this.positionY + 2, this.positionX + 5);
                    Sokoban.PrintSymbol('$');

                    this.playerMovesCount++;
                }
            }
        }
        public void LeftMovement(int positionStatusNumber)
        {
            if (positionStatusNumber == 1 || positionStatusNumber == 3)
            {
                //reach a valid position to move
                PrintLastPosition();

                this.positionY--;
                Sokoban.board[this.positionX, this.positionY] = '@';

                Console.SetCursorPosition(this.positionY + 2, this.positionX + 4);
                Sokoban.PrintSymbol('@');

                this.playerMovesCount++;
            }
            else if (positionStatusNumber == 2)
            {
                //hit a box and check the position after the box
                int nextPositionStatusNumber = GetPositionStatus(Sokoban.board, this.positionX, this.positionY - 2);

                if (nextPositionStatusNumber == 0 || nextPositionStatusNumber == 2)
                {
                    //it is a wall or a box so we can not move the box
                    return;
                }
                else
                {
                    //it is a whitespace or a place for box -> we move the box
                    PrintLastPosition();

                    Sokoban.board[this.positionX, --this.positionY] = '@';
                    Console.SetCursorPosition(this.positionY + 2, this.positionX + 4);
                    Sokoban.PrintSymbol('@');

                    Sokoban.board[this.positionX, this.positionY - 1] = '$';
                    Console.SetCursorPosition(this.positionY + 1, this.positionX + 4);
                    Sokoban.PrintSymbol('$');

                    this.playerMovesCount++;
                }
            }

        }
        public void RightMovement(int positionStatusNumber)
        {
            if (positionStatusNumber == 1 || positionStatusNumber == 3)
            {
                //reach a valid position to move
                PrintLastPosition();

                this.positionY++;
                Sokoban.board[this.positionX, this.positionY] = '@';
                Console.SetCursorPosition(this.positionY + 2, this.positionX + 4);
                Sokoban.PrintSymbol('@');

                this.playerMovesCount++;
            }
            else if (positionStatusNumber == 2)
            {
                //hit a box and check the position after the box
                int nextPositionStatusNumber = GetPositionStatus(Sokoban.board, this.positionX, this.positionY + 2);

                if (nextPositionStatusNumber == 0 || nextPositionStatusNumber == 2)
                {
                    //it is a wall or a box so we can not move the box
                    return;
                }
                else
                {
                    //it is a whitespace or a place for box -> move the box
                    PrintLastPosition();

                    Sokoban.board[this.positionX, ++this.positionY] = '@';
                    Console.SetCursorPosition(this.positionY + 2, this.positionX + 4);
                    Sokoban.PrintSymbol('@');

                    Sokoban.board[this.positionX, this.positionY + 1] = '$';
                    Console.SetCursorPosition(this.positionY + 3, this.positionX + 4);
                    Sokoban.PrintSymbol('$');
                    this.playerMovesCount++;
                }
            }
        }
        public bool CanProcessCommand(char[,] board)
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey(true);

            while (Console.KeyAvailable)
            {
                Console.ReadKey();
            }

            if (pressedKey.Key == ConsoleKey.UpArrow)
            {
                int positionStatusNumber = GetPositionStatus(board, this.positionX - 1, this.positionY);
                UpMovement(positionStatusNumber);
                return true;
            }
            else if (pressedKey.Key == ConsoleKey.DownArrow)
            {
                int positionStatusNumber = GetPositionStatus(board, this.positionX + 1, this.positionY);
                DownMovement(positionStatusNumber);
                return true;
            }
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
            {
                int positionStatusNumber = GetPositionStatus(board, this.positionX, this.positionY - 1);
                LeftMovement(positionStatusNumber);
                return true;
            }
            else if (pressedKey.Key == ConsoleKey.RightArrow)
            {
                int positionStatusNumber = GetPositionStatus(board, this.positionX, this.positionY + 1);
                RightMovement(positionStatusNumber);
                return true;
            }
            else if (pressedKey.Key == ConsoleKey.R)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 3);
                Sokoban.ReadLevelInfo(Sokoban.level);
                Sokoban.PrintBoard();
                int[] playerStartPosition = Sokoban.FindPlayerStartPosition();

                this.positionX = playerStartPosition[0];
                this.positionY = playerStartPosition[1];
                this.playerMovesCount = 0;

                return true;
            }
            else if (pressedKey.Key == ConsoleKey.E)
            {
                Console.SetCursorPosition(0, board.GetLength(0) + 3);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You chose to exit the game!");
                Console.WriteLine("Goodbye. : )");
                Environment.Exit(0);
                return true;
            }
            return false;
        }
    }
}
