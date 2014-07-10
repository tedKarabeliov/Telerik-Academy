using System;
using System.Collections.Generic;

struct Point
{
    public int Row { get; set; }
    public int Col { get; set; }

    public Point(int row, int col)
        : this()
    {
        this.Row = row;
        this.Col = col;
    }
}

class Labyrinth
{
    private static string[,] arr = new string[,] {
        {"0", "0", "0", "x", "0", "x"},
        {"0", "x", "0", "x", "0", "x"},
        {"0", "*", "x", "0", "x", "0"},
        {"0", "x", "0", "0", "0", "0"},
        {"0", "0", "0", "x", "x", "0"},
        {"0", "0", "0", "x", "0", "x"}
    };
    private static Queue<Point> queue = new Queue<Point>();

    private static void DFS(Point position, int fillValue)
    {
        AssignNeighboursToQueue(position);
        if (queue.Count == 0)
        {
            return;
        }

        fillValue++;
        var neighbours = new List<Point>();
        while (queue.Count != 0)
        {
            neighbours.Add(queue.Dequeue());
            arr[neighbours[neighbours.Count - 1].Row, neighbours[neighbours.Count - 1].Col] = fillValue.ToString();
        }
        for (int i = 0; i < neighbours.Count; i++)
        {
            DFS(new Point(neighbours[i].Row, neighbours[i].Col), fillValue);
        }
    }

    private static Point FindStartPosition()
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (arr[row, col] == "*")
                {
                    return new Point(row, col);
                }
            }
        }
        throw new ArgumentException("Player starting position not found");
    }

    private static void AssignNeighboursToQueue(Point position)
    {
        if (position.Col + 1 < arr.GetLength(1) && arr[position.Row, position.Col + 1] == "0")
        {
            queue.Enqueue(new Point(position.Row, position.Col + 1));
        }
        if (position.Col - 1 >= 0 && arr[position.Row, position.Col - 1] == "0")
        {
            queue.Enqueue(new Point(position.Row, position.Col - 1));
        }
        if (position.Row - 1 >= 0 && arr[position.Row - 1, position.Col] == "0")
        {
            queue.Enqueue(new Point(position.Row - 1, position.Col));
        }
        if (position.Row + 1 < arr.GetLength(0) && arr[position.Row + 1, position.Col] == "0")
        {
            queue.Enqueue(new Point(position.Row + 1, position.Col));
        }
    }

    private static void AssignUnvisitedCells()
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (arr[row, col] == "0")
                {
                    arr[row, col] = "u";
                }
            }
        }
    }

    private static void PrintArr()
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(arr[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Point startPosition = FindStartPosition();
        int fillValue = 0;
        DFS(startPosition, fillValue);
        AssignUnvisitedCells();
        PrintArr();
    }
}