
// 1. Spiral Matris
using System;

class Program
{
    static void SpiralMatrix(int N)
    {
        int[,] matrix = new int[N, N];
        int value = 1, minCol = 0, maxCol = N - 1, minRow = 0, maxRow = N - 1;

        while (value <= N * N)
        {
            for (int i = minCol; i <= maxCol; i++)
                matrix[minRow, i] = value++;
            minRow++;

            for (int i = minRow; i <= maxRow; i++)
                matrix[i, maxCol] = value++;
            maxCol--;

            for (int i = maxCol; i >= minCol; i--)
                matrix[maxRow, i] = value++;
            maxRow--;

            for (int i = maxRow; i >= minRow; i--)
                matrix[i, minCol] = value++;
            minCol++;
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of matrix:");
        int N = int.Parse(Console.ReadLine());
        SpiralMatrix(N);
    }
}

// 2. İki Matrisin Çarpımı
using System;

class MatrixMultiplication
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of matrices (N):");
        int N = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[N, N];
        int[,] matrix2 = new int[N, N];
        int[,] result = new int[N, N];

        Console.WriteLine("Enter elements of first matrix:");
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                matrix1[i, j] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of second matrix:");
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                matrix2[i, j] = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < N; k++)
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }

        Console.WriteLine("Resultant matrix:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(result[i, j] + "\t");
            Console.WriteLine();
        }
    }
}

// 3. N'e Kadar Asal Sayıların Toplamı
using System;

class PrimeSum
{
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
            if (num % i == 0) return false;
        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 2; i <= N; i++)
        {
            if (IsPrime(i))
                sum += i;
        }

        Console.WriteLine("Sum of primes till N is: " + sum);
    }
}

// 4. TechCity Robot Problemi
using System;
using System.Collections.Generic;

class RobotProblem
{
    static int[,] directions = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };

    static bool IsValid(int x, int y, int N, int[,] grid, bool[,] visited)
    {
        return x >= 0 && y >= 0 && x < N && y < N && grid[x, y] == 1 && !visited[x, y];
    }

    static int DFS(int x, int y, int N, int[,] grid, bool[,] visited)
    {
        visited[x, y] = true;
        int count = 1;

        for (int i = 0; i < 4; i++)
        {
            int newX = x + directions[i, 0];
            int newY = y + directions[i, 1];
            if (IsValid(newX, newY, N, grid, visited))
                count += DFS(newX, newY, N, grid, visited);
        }

        return count;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the grid (N):");
        int N = int.Parse(Console.ReadLine());
        int[,] grid = new int[N, N];

        Console.WriteLine("Enter the grid values (0 or 1):");
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                grid[i, j] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of robots:");
        int robotCount = int.Parse(Console.ReadLine());
        List<(int, int)> robots = new List<(int, int)>();
        
        Console.WriteLine("Enter robot starting positions:");
        for (int i = 0; i < robotCount; i++)
        {
            string[] position = Console.ReadLine().Split();
            robots.Add((int.Parse(position[0]), int.Parse(position[1])));
        }

        bool[,] visited = new bool[N, N];
        int totalSavedNodes = 0;

        foreach (var robot in robots)
            totalSavedNodes += DFS(robot.Item1, robot.Item2, N, grid, visited);

        Console.WriteLine("Total saved nodes: " + totalSavedNodes);
    }
}

// 5. Labirent Problemi (En Kısa Yol)
using System;
using System.Collections.Generic;

class MazeProblem
{
    static int[,] directions = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };

    static bool IsValid(int x, int y, int N, int[,] maze, bool[,] visited)
    {
        return x >= 0 && y >= 0 && x < N && y < N && maze[x, y] == 1 && !visited[x, y];
    }

    static int FindShortestPath(int[,] maze, int N)
    {
        bool[,] visited = new bool[N, N];
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();

        queue.Enqueue((0, 0, 0)); // (x, y, steps)
        visited[0, 0] = true;

        while (queue.Count > 0)
        {
            var (x, y, steps) = queue.Dequeue();

            if (x == N - 1 && y == N - 1)
                return steps;

            for (int i = 0; i < 4; i++)
            {
                int newX = x + directions[i, 0];
                int newY = y + directions[i, 1];

                if (IsValid(newX, newY, N, maze, visited))
                {
                    visited[newX, newY] = true;
                    queue.Enqueue((newX, newY, steps + 1));
                }
            }
        }

        return -1; // Yol Yok
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the maze (N):");
        int N = int.Parse(Console.ReadLine());
        int[,] maze = new int[N, N];

        Console.WriteLine("Enter the maze grid (0 for walls, 1 for paths):");
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                maze[i, j] = int.Parse(Console.ReadLine());

        int result = FindShortestPath(maze, N);

        if (result == -1)
            Console.WriteLine("Yol Yok");
        else
            Console.WriteLine("En Kısa Yol: " + result + " adım");
    }
}
